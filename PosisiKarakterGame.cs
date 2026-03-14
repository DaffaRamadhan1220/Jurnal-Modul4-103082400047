using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurnalModul4_103082400047
{
    public enum StateKarakter
    {
        Berdiri,
        Jongkok,
        Tengkurap,
        Terbang
    }

    public class PosisiKarakterGame
    {
        private StateKarakter currentState;
        private readonly int nimMod; 
        
        public PosisiKarakterGame(int nimTerakhir)
        {
            currentState = StateKarakter.Berdiri; 
            nimMod = nimTerakhir % 3;
            Console.WriteLine($"State awal: Berdiri (NIM % 3 = {nimMod})");
        }

        
        public void TombolW()
        {
            Console.WriteLine("\n[TombolW ditekan]");

            
            if (nimMod == 0)
            {
                Console.WriteLine("tombol arah atas ditekan");
            }

            StateKarakter previousState = currentState;

            
            switch (currentState)
            {
                case StateKarakter.Berdiri:
                    currentState = StateKarakter.Terbang;
                    
                    if (nimMod == 2 && previousState == StateKarakter.Berdiri && currentState == StateKarakter.Terbang)
                    {
                        Console.WriteLine("posisi take off");
                    }
                    break;

                case StateKarakter.Jongkok:
                    currentState = StateKarakter.Berdiri;
                    break;

                case StateKarakter.Tengkurap:
                    currentState = StateKarakter.Jongkok;
                    break;

                case StateKarakter.Terbang:
                    
                    break;
            }

            
            if (nimMod != 0)
            {
                Console.WriteLine($"State berubah: {previousState} -> {currentState}");
            }

            
            if (nimMod == 1 && currentState == StateKarakter.Berdiri)
            {
                Console.WriteLine("posisi standby");
            }
        }

        
        public void TombolS()
        {
            Console.WriteLine("\n[TombolS ditekan]");

            
            if (nimMod == 0)
            {
                Console.WriteLine("tombol arah bawah ditekan");
            }

            StateKarakter previousState = currentState;

            
            switch (currentState)
            {
                case StateKarakter.Berdiri:
                    currentState = StateKarakter.Jongkok;
                    break;

                case StateKarakter.Jongkok:
                    currentState = StateKarakter.Tengkurap;
                    break;

                case StateKarakter.Tengkurap:
                    
                    break;

                case StateKarakter.Terbang:
                    currentState = StateKarakter.Jongkok;
                    
                    if (nimMod == 2 && previousState == StateKarakter.Terbang && currentState == StateKarakter.Jongkok)
                    {
                        Console.WriteLine("posisi landing");
                    }
                    break;
            }

            
            if (nimMod != 0)
            {
                Console.WriteLine($"State berubah: {previousState} -> {currentState}");
            }

            
            if (nimMod == 1 && currentState == StateKarakter.Tengkurap)
            {
                Console.WriteLine("posisi istirahat");
            }
        }

        
        public StateKarakter GetCurrentState()
        {
            return currentState;
        }
    }
}
