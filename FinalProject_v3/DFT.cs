﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinalProject_v3
{
    /*
        DFT
        Purpose:
            Object to store all functions for Descrete Fourier Transform calls.
            Created to clear up code, and to pass information through.
    */
    class DFT
    {
        private double[] threadAmplitude;
        private double[] threadOne, threadTwo, threadThree, threadFour;

        /* This returns an arry of complex numbers. This is not the amplitude of the wave. It must be run through Pythagorus. */
        /*
            DFTFunc
            Purpose:
                Forward DFT for a double array of samples of size n. This 
                converts data in the time domain to the frequency domain. It
                returns a complex number array for usage in inverse DFT 
                funcitons. To properly plot the data returned from this, data
                will have to be run through pythagorus.
            Parameters:
                s:  Signal we are changing
                n:  Size of the signal
        */
        public newComplex[] DFTFunc(double[] s, int n)
        {
            newComplex[] cmplx = new newComplex[n];
            double re; /*real*/
            double im; /*imaginary*/
            for (int f = 0; f < n - 1; f++)
            {
                re = 0;
                im = 0;
                for (int t = 0; t < n - 1; t++)
                {
                    re += s[t] * Math.Cos(2 * Math.PI * t * f / n);
                    im -= s[t] * Math.Sin(2 * Math.PI * t * f / n);
                }
                cmplx[f] = new newComplex(re, im);
            }
            return cmplx;
        }

        /*
            newDFTFunc
            Purpose:
                Forward DFT for a double array of samples of size n. This 
                converts data in the time domain to the frequency domain. 
                This will perform pythagorus to convert the complex array
                directly to usable data for the frequency domain chart.
            Parameters:
                s:  Signal we are changing
                n:  Size of the signal
        */
        public double[] newDFTFunc(double[] s, int n)
        {
            double[] amplitude = new double[n];
            double temp;
            newComplex cmplx;
            double re; /*real*/
            double im; /*imaginary*/
            for (int f = 0; f < n - 1; f++)
            {
                re = 0;
                im = 0;
                for (int t = 0; t < n - 1; t++)
                {
                    re += s[t] * Math.Cos(2 * Math.PI * t * f / n);
                    im -= s[t] * Math.Sin(2 * Math.PI * t * f / n);
                }
                cmplx = new newComplex(re, im);
                temp = (cmplx.getReal() * cmplx.getReal()) + (cmplx.getImaginary() * cmplx.getImaginary());
                temp = Math.Sqrt(temp);
                amplitude[f] = temp; // These are the points we are going to plot.

                // am I squaring i?
            }
            return amplitude;
        }

        /* Preforms the inverse of DFT: this will be displayed to the graph for testing with cosWavCreation */
        /*
            invDFT
            Purpose:
                Inverse Descrete Fourier Transform, used to convert from the
                frequency domain to the time domain.
            Parameters:
                A:  Complex array to convert
                n:  Size of the complex array
        */
        public double[] invDFT(newComplex[] A, int n)
        {
            double[] s = new double[n];
            double re; /*real*/
            double im; /*imaginary*/
            for (int t = 0; t < n - 1; t++)
            {
                re = 0;
                im = 0;
                for (int f = 0; f < n - 1; f++)
                {
                    re += A[f].getReal() * Math.Cos(2 * Math.PI * t * f / n);
                    im -= A[f].getImaginary() * Math.Sin(2 * Math.PI * t * f / n);
                }
                s[t] = (re + im) / n;
            }
            return s;
        }

        // Threading function. This can take in the data, or just the object
        private void runningDFT(double[] s, int n, int threadNum, int maxThreads)
        {
            double temp;
            newComplex cmplx;
            double re; //real
            double im; //imaginary

            int startP = ((n / maxThreads) * (threadNum - 1)), endP = ((n / maxThreads) * (threadNum));
            /*
            if(startP < 0)
            {
                startP = 0;
            }
            */
            if (threadNum == maxThreads - 1)
            {
                endP = n;
            }

            // for (int f = startP; f < endP; f++) // run through first half // old
            for (int f = 0; f < n / maxThreads; f++) // run through first half
            {
                re = 0;
                im = 0;
                for (int t = 0; t < n - 1; t++)
                {
                    re += s[t] * Math.Cos(2 * Math.PI * t * f / n);
                    im -= s[t] * Math.Sin(2 * Math.PI * t * f / n);
                }
                cmplx = new newComplex(re, im);
                temp = (cmplx.getReal() * cmplx.getReal()) + (cmplx.getImaginary() * cmplx.getImaginary());
                temp = Math.Sqrt(temp);

                switch (threadNum - 1)
                {
                    case 1:
                        threadOne[f] = temp;
                        break;
                    case 2:
                        threadTwo[f] = temp;
                        break;
                    case 3:
                        threadThree[f] = temp;
                        break;
                    case 4:
                        threadFour[f] = temp;
                        break;
                }

                //threadAmplitude[f] = temp; // These are the points we are going to plot.
            }
        }

        /*
            threadDFTFunc
            Purpose:
                
            Parameters:
                
        */
        public double[] threadDFTFunc(double[] s, int n, int threadNum)
        {
            Thread[] tArray = new Thread[threadNum];
            double[][] amp = new double[threadNum][];
            threadAmplitude = new double[n];

            switch (threadNum)
            {
                case 1:
                    threadOne = new double[n];
                    break;
                case 2:
                    threadOne = new double[n / threadNum];
                    threadTwo = new double[n / threadNum];
                    break;
                case 3:
                    threadOne = new double[n / threadNum];
                    threadTwo = new double[n / threadNum];
                    threadThree = new double[n / threadNum];
                    break;
                case 4:
                    threadOne = new double[n / threadNum];
                    threadTwo = new double[n / threadNum];
                    threadThree = new double[n / threadNum];
                    threadFour = new double[n / threadNum];
                    break;
            }

            for (int t = 0; t < threadNum; t++)
            {
                tArray[t] = new Thread(() => { runningDFT(s, n, t, threadNum); });
                tArray[t].Start();
            }

            foreach (Thread th in tArray)
                th.Join();

            // Add all the new data to the total amplitude
            switch (threadNum)
            {
                case 1:
                    Array.Copy(threadOne, threadAmplitude, threadOne.Length);
                    break;
                case 2:
                    Array.Copy(threadOne, 0, threadAmplitude, 0, threadOne.Length);
                    Array.Copy(threadTwo, 0, threadAmplitude, (threadOne.Length + 1), threadTwo.Length);
                    break;
                case 3:

                    break;
                case 4:

                    break;
            }

            return threadAmplitude;
        }
    }
}
