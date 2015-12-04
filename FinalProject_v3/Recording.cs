﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace FinalProject_v3
{
    class Recording
    {
        /*
            WAVEFORMAT
            Purpose:
                This is the wave format of the data saved. This will be used to
                record the data, and will be updated when playing the sound 
                back from the input form.
            
        */
        [StructLayout(LayoutKind.Sequential)]
        public struct WAVEFORMAT
        {
            public ushort wFormatTag;
            public ushort nChannels;
            public uint nSamplesPerSec;
            public uint nAvgBytesPerSec;
            public ushort nBlockAlign;
            public ushort wBitPerSample;
            public ushort cbSize;
        }

        /*
            WAVEHDR
            Purpose:
                This is information for the class below. This is used and 
                passed back to C functions inside the DLLImported functions
                to determine if we wish to call any specific flags or loops.
                The main purpose is to hold onto the header information for
                playing or recording.
        */
        [StructLayout(LayoutKind.Sequential)]
        public struct WAVEHDR
        {
            public IntPtr lpData;
            public uint dwBufferLength;
            public uint dwBytesRecorded;
            public IntPtr dwUser;
            public uint dwFlags;
            public uint dwLoops;
            public IntPtr lpNext;
            public IntPtr reserved;
        }

        /*
            RecordingDelegate
            Purpose:
                This function will be used in the class to call the recording 
                function from the DLLImport.
            Parameters:
                deviceHandle:   This is the handle to the device we are 
                                recording from. This is passed in from by the 
                                OS
                message:        Message to pass into the OS to begin recording
                hInstance:      This is used as an instance to the window for 
                                the "callback" function in the recording proc
                wavehdr:        The WAVEHDR structure to record the data with
                reserved2:      Place to save the recorded data to.
        */
        public delegate void RecordingDelegate(IntPtr deviceHandle, uint message, IntPtr hInstance, ref WAVEHDR wavehdr, IntPtr reserved2);

        /*
            waveInAddBuffer
            Purpose:
                This is the DLLImport for the C function to get the wave in 
                buffer for setting up the buffer for recording.
            Parameters:
                hWaveIn:        Handle to the wave in for the window where we are 
                                calling the functions from.
                lpWaveHder:     Reference to the WAVEHDR structure for the format
                                we are recording the data in.
                cWaveHdrSize:   Size of the WAVEHDR structure
        */
        [DllImport("winmm.dll")]
        public static extern int waveInAddBuffer(IntPtr hWaveIn, ref WAVEHDR lpWaveHdr, uint cWaveHdrSize);
        /*
            waveInPrepareHeader
            Purpose:
                This will begin preparing the header for recording. This sets
                up the recording device so that it will be ready to record the
                information passed to it in the correct format.
            Parameters:
                hWaveIn:        Handle to the wave in for the window where we are 
                                calling the functions from.
                lpWaveHder:     Reference to the WAVEHDR structure for the format
                                we are recording the data in.
                cWaveHdrSize:   Size of the WAVEHDR structure
        */
        [DllImport("winmm.dll")]
        public static extern int waveInPrepareHeader(IntPtr hWaveIn, ref WAVEHDR lpWaveHdr, uint cWaveHdrSize);
        /*
            waveInStart
            Purpose:
                Called when we wish to start recording.
            Parameters:
                hWaveIn:    Handle to the window we are calling this function 
                            from
        */
        [DllImport("winmm.dll")]
        public static extern int waveInStart(IntPtr hWaveIn);
        /*
            waveInOpen
            Purpose:
                Function to open the wave to start the recording for the call.
            Parameters:
                t:
                id:
                pwfx:
                dwCallback:
                dwInstance:
                fdwOpen:
        */
        [DllImport("winmm.dll", EntryPoint = "waveInOpen", SetLastError = true)]
        public static extern int waveInOpen(ref IntPtr t, uint id, ref WAVEFORMAT pwfx, IntPtr dwCallback, int dwInstance, int fdwOpen);
        /*
            waveInUnprepareHeader
            Purpose:
                
            Parameters:
                
        */
        [DllImport("winmm.dll", EntryPoint = "waveInUnprepareHeader", SetLastError = true)]
        public static extern int waveInUnprepareHeader(IntPtr hwi, ref WAVEHDR pwh, uint cbwh);
        /*
            waveInUnprepareHeader
            Purpose:
                
            Parameters:
                
        */
        [DllImport("winmm.dll", EntryPoint = "waveInStop", SetLastError = true)]
        static extern uint waveInStop(IntPtr hwi);
        /*
            waveInUnprepareHeader
            Purpose:
                
            Parameters:
                
        */
        [DllImport("winmm.dll", EntryPoint = "waveInClose", SetLastError = true)]
        public static extern uint waveInClose(IntPtr hwnd);
        /*
            waveInUnprepareHeader
            Purpose:
                
            Parameters:
                
        */
        [DllImport("winmm.dll", EntryPoint = "waveInReset", SetLastError = true)]
        static extern uint waveInReset(IntPtr hwi);
        /*
            waveInUnprepareHeader
            Purpose:
                
            Parameters:
                
        */
        [DllImport("winmm.dll", EntryPoint = "waveOutOpen", SetLastError = true)]
        public static extern int waveOutOpen(ref IntPtr t, uint id, ref WAVEFORMAT pwfx, IntPtr dwCallback, int dwInstance, int fdwOpen);
        /*
            waveInUnprepareHeader
            Purpose:
                
            Parameters:
                
        */
        [DllImport("winmm.dll", EntryPoint = "waveOutPrepareHeader", SetLastError = true)]
        public static extern int waveOutPrepareHeader(IntPtr hWaveIn, ref WAVEHDR lpWaveHdr, uint Size);
        /*
            waveInUnprepareHeader
            Purpose:
                
            Parameters:
                
        */
        [DllImport("winmm.dll", EntryPoint = "waveOutWrite", SetLastError = true)]
        public static extern int waveOutWrite(IntPtr hWaveIn, ref WAVEHDR lpWaveHdr, uint Size);
        /*
            waveInUnprepareHeader
            Purpose:
                
            Parameters:
                
        */
        [DllImport("winmm.dll", EntryPoint = "waveOutUnprepareHeader", SetLastError = true)]
        public static extern int waveOutUnprepareHeader(IntPtr hwi, ref WAVEHDR pwh, uint cbwh);
        /*
            waveInUnprepareHeader
            Purpose:
                
            Parameters:
                
        */
        [DllImport("winmm.dll", EntryPoint = "waveOutClose", SetLastError = true)]
        public static extern uint waveOutClose(IntPtr hwnd);
        /*
            waveInUnprepareHeader
            Purpose:
                
            Parameters:
                
        */
        [DllImport("winmm.dll", EntryPoint = "waveOutStart", SetLastError = true)]
        public static extern int waveOutStart(IntPtr hWaveIn);
        /*
            waveInUnprepareHeader
            Purpose:
                
            Parameters:
                
        */
        [DllImport("winmm.dll", EntryPoint = "waveOutStop", SetLastError = true)]
        static extern uint waveOutStop(IntPtr hwi);
        /*
            waveInUnprepareHeader
            Purpose:
                
            Parameters:
                
        */
        [DllImport("winmm.dll", EntryPoint = "waveOutReset", SetLastError = true)]
        static extern uint waveOutReset(IntPtr hwi);


        private Recording.RecordingDelegate waveIn;
        private IntPtr hnd;
        private IntPtr hndWavOut;
        private uint bufferLength;
        private WAVEFORMAT format;
        private WAVEHDR head;
        private WAVEHDR oHead;
        private GCHandle headerPin;
        private GCHandle bufferPin;
        private GCHandle savePin;

        private byte[] savedDataSound;
        private byte[] tempSound;

        public wave_file_header getHeader()
        {
            wave_file_header header = new wave_file_header();

            header.init(); // riff, wav, fmd, data
                           // chunkID, format, subchunk1id, subchunk2id
            /*
            public ushort wFormatTag;
            public ushort nChannels;
            public uint nSamplesPerSec;
            public uint nAvgBytesPerSec;
            public ushort nBlockAlign;
            public ushort wBitPerSample;
            public ushort cbSize;
            */
            header.SubChunk1Size = 16;
            header.AudioFormat = format.wFormatTag;
            header.NumChannels = format.nChannels;
            header.SampleRate = format.nSamplesPerSec;
            header.ByteRate = format.nAvgBytesPerSec;
            header.BlockAlign = format.nBlockAlign;
            header.BitsPerSample = format.wBitPerSample;
            // chunk size and subchunk2size not set

            // chunk size based on subchunk2size + 44 (44 for the size of the header)

            return header;
        }

        public void Record()
        {
            setupWaveIn();
        }

        private void setupBuffer()
        {
            head.lpData = bufferPin.AddrOfPinnedObject();
            head.dwBufferLength = bufferLength;
            head.dwFlags = 0;
            head.dwBytesRecorded = 0;
            head.dwLoops = 0;
            head.dwUser = IntPtr.Zero;
            head.lpNext = IntPtr.Zero;
            head.reserved = IntPtr.Zero;
            headerPin = GCHandle.Alloc(head, GCHandleType.Pinned);

            int i = Recording.waveInPrepareHeader(this.hnd, ref head, Convert.ToUInt32(Marshal.SizeOf(head)));
            if (i != 0)
            {
                //Error in waveIn
                return;
            }

            i = Recording.waveInAddBuffer(hnd, ref head, Convert.ToUInt32(Marshal.SizeOf(head)));
            if (i != 0)
            {
                //Error om waveInAdd
                return;
            }
        }

        private void setupOutbuffer()
        {
            oHead.lpData = savePin.AddrOfPinnedObject();
            oHead.dwBufferLength = (uint)savedDataSound.Length;
            oHead.dwFlags = 0x00000004 | 0x00000008;
            oHead.dwBytesRecorded = 0;
            oHead.dwLoops = 1;
            oHead.lpNext = IntPtr.Zero;
            oHead.reserved = IntPtr.Zero;

            int i = Recording.waveOutPrepareHeader(hndWavOut, ref oHead, Convert.ToUInt32(Marshal.SizeOf(oHead)));
            if (i != 0)
                return;

            i = Recording.waveOutWrite(hndWavOut, ref oHead, Convert.ToUInt32(Marshal.SizeOf(oHead)));
            if (i != 0)
                return;
        }

        public void play(double[] data, wave_file_header waveHeader)
        {
            int[] intAr = data.Select(x => Convert.ToInt32(Math.Round(x))).ToArray();
            byte[] waveByteData = intAr.Select(x => Convert.ToInt16(x)).SelectMany(x => BitConverter.GetBytes(x)).ToArray();
            savedDataSound = waveByteData;
            savePin = GCHandle.Alloc(savedDataSound, GCHandleType.Pinned);
            
            hndWavOut = new IntPtr();
            waveIn = this.callbackWaveOut;
            
            format.wFormatTag = 1; // WAVE_FORMAT_PCM
            format.nChannels = waveHeader.NumChannels;
            format.nSamplesPerSec = waveHeader.SampleRate;
            format.wBitPerSample = waveHeader.BitsPerSample;
            format.nBlockAlign = waveHeader.BlockAlign;
            format.nAvgBytesPerSec = waveHeader.ByteRate;

            savePin = GCHandle.Alloc(waveByteData, GCHandleType.Pinned);
            format.cbSize = 0;

            //WAVE_MAPPER
            int i = Recording.waveOutOpen(ref hndWavOut, 4294967295, ref format, Marshal.GetFunctionPointerForDelegate(waveIn), 0, 0x0030000);
            if (i != 0)
            {
                //Error
                return;
            }
            setupOutbuffer();
        }

        /*
            Not implemented
        */
        public void stop_playing()
        {
        }

        private void setupWaveIn()
        {
            savedDataSound = null;
            hnd = new IntPtr();
            waveIn = this.callbackWaveIn;

            format.wFormatTag = 1; //WAVE_FORMAT_PCM
            format.nChannels = 1;
            format.nSamplesPerSec = 22050;
            format.wBitPerSample = 16;
            format.nBlockAlign = (ushort)(format.wBitPerSample / 8);
            format.nAvgBytesPerSec = (format.nSamplesPerSec * format.nBlockAlign);

            bufferLength = format.nSamplesPerSec * 2;
            format.cbSize = 0;

            tempSound = new byte[bufferLength];
            bufferPin = GCHandle.Alloc(tempSound, GCHandleType.Pinned);

            int i = Recording.waveInOpen(ref hnd, 4294967295, ref format, Marshal.GetFunctionPointerForDelegate(waveIn), 0, 0x0030000);
            if (i != 0)
            {
                //Error
                return;
            }
            setupBuffer();
            i = waveInStart(hnd);
            if (i != 0)
            {
                //error
            }
        }

        private void callbackWaveIn(IntPtr deviceHandle, uint message, IntPtr instance, ref WAVEHDR wavehdr, IntPtr reserved2)
        {
            if (message == 0x3C0) //WIM_DATA
            {
                if (savedDataSound != null)
                {
                    List<byte> temp = savedDataSound.ToList(); // easier to add onto a list
                    temp.AddRange(tempSound.ToList());
                    savedDataSound = temp.ToArray();
                }
                else
                {
                    savedDataSound = tempSound;
                }

                savePin = GCHandle.Alloc(savedDataSound, GCHandleType.Pinned);
                tempSound = new byte[bufferLength]; // sets up a clean buffer
                bufferPin = GCHandle.Alloc(tempSound, GCHandleType.Pinned);

                int i = waveInUnprepareHeader(deviceHandle, ref head, Convert.ToUInt32(Marshal.SizeOf(head)));
                if (i != 0) //MMSYSERR_NOERROR
                {
                    //Error
                    return;
                }
                setupBuffer();
            }
        }

        private void callbackWaveOut(IntPtr deviceHandle, uint message, IntPtr instance, ref WAVEHDR wavehdr, IntPtr reserved2)
        {
            if (message == 0x3C0) //WIM_DATA
            {
                List<byte> temp = savedDataSound.ToList();
                temp.AddRange(tempSound.ToList());
                savedDataSound = temp.ToArray();

                savePin = GCHandle.Alloc(savedDataSound, GCHandleType.Pinned);
                int i = waveInUnprepareHeader(deviceHandle, ref head, Convert.ToUInt32(Marshal.SizeOf(head)));
                if (i != 0) //MMSYSERR_NOERROR
                {
                    //Error
                    return;
                }
                setupBuffer();
            }
        }

        public byte[] stop()
        {
            waveInStop(hnd);
            waveInClose(hnd);

            bufferPin.Free();
            savePin.Free();

            return savedDataSound;
        }
    }
}