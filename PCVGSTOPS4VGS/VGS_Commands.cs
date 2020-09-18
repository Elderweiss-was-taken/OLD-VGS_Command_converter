using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCVGSTOPS4VGS
{
    public static class VGS_Commands
    {
        public static List<string> ListOfVgsCommands;
        public static List<char>   ListOfAllDifferentCharsUsedForAllThePossibleVgsCommands;
        public static List<string> ListOfAllDifferentCharsUsedForAllThePossibleVgsCommands_ToString;

        public static void Initialize()
        {
            #region ListOfVgsCommands
            ListOfVgsCommands = new List<string>();
            #region adding to the list
            ListOfVgsCommands.Add("VA1");
            ListOfVgsCommands.Add("VA2");
            ListOfVgsCommands.Add("VA3");
            ListOfVgsCommands.Add("VAA");
            ListOfVgsCommands.Add("VAF");
            ListOfVgsCommands.Add("VAG");
            ListOfVgsCommands.Add("VAM");
            ListOfVgsCommands.Add("VAT1");
            ListOfVgsCommands.Add("VAT2");
            ListOfVgsCommands.Add("VAT3");
            ListOfVgsCommands.Add("VB1");
            ListOfVgsCommands.Add("VB2");
            ListOfVgsCommands.Add("VB3");
            ListOfVgsCommands.Add("VBA");
            ListOfVgsCommands.Add("VBB");
            ListOfVgsCommands.Add("VBD");
            ListOfVgsCommands.Add("VBE");
            ListOfVgsCommands.Add("VBF");
            ListOfVgsCommands.Add("VBG");
            ListOfVgsCommands.Add("VBJ1");
            ListOfVgsCommands.Add("VBJ3");
            ListOfVgsCommands.Add("VBJJ");
            ListOfVgsCommands.Add("VBM");
            ListOfVgsCommands.Add("VBS");
            ListOfVgsCommands.Add("VC1");
            ListOfVgsCommands.Add("VC2");
            ListOfVgsCommands.Add("VC3");
            ListOfVgsCommands.Add("VCB");
            ListOfVgsCommands.Add("VCC");
            ListOfVgsCommands.Add("VCJ");
            ListOfVgsCommands.Add("VD1");
            ListOfVgsCommands.Add("VD2");
            ListOfVgsCommands.Add("VD3");
            ListOfVgsCommands.Add("VDD");
            ListOfVgsCommands.Add("VDF");
            ListOfVgsCommands.Add("VDG");
            ListOfVgsCommands.Add("VDM");
            ListOfVgsCommands.Add("VEA");
            ListOfVgsCommands.Add("VEG");
            ListOfVgsCommands.Add("VEJ");
            ListOfVgsCommands.Add("VEL");
            ListOfVgsCommands.Add("VER");
            ListOfVgsCommands.Add("VET");
            ListOfVgsCommands.Add("VEW");
            ListOfVgsCommands.Add("VF1");
            ListOfVgsCommands.Add("VF2");
            ListOfVgsCommands.Add("VF3");
            ListOfVgsCommands.Add("VFF");
            ListOfVgsCommands.Add("VG1");
            ListOfVgsCommands.Add("VG2");
            ListOfVgsCommands.Add("VG3");
            ListOfVgsCommands.Add("VGG");
            ListOfVgsCommands.Add("VH1");
            ListOfVgsCommands.Add("VH2");
            ListOfVgsCommands.Add("VH3");
            ListOfVgsCommands.Add("VHH");
            ListOfVgsCommands.Add("VHS");
            ListOfVgsCommands.Add("VI1");
            ListOfVgsCommands.Add("VI2");
            ListOfVgsCommands.Add("VI3");
            ListOfVgsCommands.Add("VII");
            ListOfVgsCommands.Add("VQ1");
            ListOfVgsCommands.Add("VQ2");
            ListOfVgsCommands.Add("VQ3");
            ListOfVgsCommands.Add("VQF");
            ListOfVgsCommands.Add("VQG");
            ListOfVgsCommands.Add("VQN");
            ListOfVgsCommands.Add("VQQ");
            ListOfVgsCommands.Add("VR1");
            ListOfVgsCommands.Add("VR2");
            ListOfVgsCommands.Add("VR3");
            ListOfVgsCommands.Add("VRJ");
            ListOfVgsCommands.Add("VRR");
            ListOfVgsCommands.Add("VRS");
            ListOfVgsCommands.Add("VSA1");
            ListOfVgsCommands.Add("VSA2");
            ListOfVgsCommands.Add("VSA3");
            ListOfVgsCommands.Add("VSAA");
            ListOfVgsCommands.Add("VSAF");
            ListOfVgsCommands.Add("VSAG");
            ListOfVgsCommands.Add("VSAM");
            ListOfVgsCommands.Add("VSBB");
            ListOfVgsCommands.Add("VSBN");
            ListOfVgsCommands.Add("VSBT");
            ListOfVgsCommands.Add("VSD1");
            ListOfVgsCommands.Add("VSD2");
            ListOfVgsCommands.Add("VSD3");
            ListOfVgsCommands.Add("VSDD");
            ListOfVgsCommands.Add("VSDF");
            ListOfVgsCommands.Add("VSDG");
            ListOfVgsCommands.Add("VSDM");
            ListOfVgsCommands.Add("VSG1");
            ListOfVgsCommands.Add("VSG2");
            ListOfVgsCommands.Add("VSG3");
            ListOfVgsCommands.Add("VSGG");
            ListOfVgsCommands.Add("VSO");
            ListOfVgsCommands.Add("VSQ1");
            ListOfVgsCommands.Add("VSQ2");
            ListOfVgsCommands.Add("VSQ3");
            ListOfVgsCommands.Add("VSQQ");
            ListOfVgsCommands.Add("VSR");
            ListOfVgsCommands.Add("VSS");
            ListOfVgsCommands.Add("VST1");
            ListOfVgsCommands.Add("VST2");
            ListOfVgsCommands.Add("VST3");
            ListOfVgsCommands.Add("VSTB");
            ListOfVgsCommands.Add("VSTT");
            ListOfVgsCommands.Add("VT1");
            ListOfVgsCommands.Add("VT2");
            ListOfVgsCommands.Add("VT3");
            ListOfVgsCommands.Add("VTT");
            ListOfVgsCommands.Add("VVA");
            ListOfVgsCommands.Add("VVB");
            ListOfVgsCommands.Add("VVC");
            ListOfVgsCommands.Add("VVGB");
            ListOfVgsCommands.Add("VVGF");
            ListOfVgsCommands.Add("VVGG");
            ListOfVgsCommands.Add("VVGH");
            ListOfVgsCommands.Add("VVGL");
            ListOfVgsCommands.Add("VVGN");
            ListOfVgsCommands.Add("VVGO");
            ListOfVgsCommands.Add("VVGQ");
            ListOfVgsCommands.Add("VVGR");
            ListOfVgsCommands.Add("VVGS");
            ListOfVgsCommands.Add("VVGT");
            ListOfVgsCommands.Add("VVGW");
            ListOfVgsCommands.Add("VVK");
            ListOfVgsCommands.Add("VVM");
            ListOfVgsCommands.Add("VVN");
            ListOfVgsCommands.Add("VVP");
            ListOfVgsCommands.Add("VVS");
            ListOfVgsCommands.Add("VVT");
            ListOfVgsCommands.Add("VVVA");
            ListOfVgsCommands.Add("VVVB");
            ListOfVgsCommands.Add("VVVC");
            ListOfVgsCommands.Add("VVVD");
            ListOfVgsCommands.Add("VVVE");
            ListOfVgsCommands.Add("VVVF");
            ListOfVgsCommands.Add("VVVG");
            ListOfVgsCommands.Add("VVVJ");
            ListOfVgsCommands.Add("VVVP");
            ListOfVgsCommands.Add("VVVR");
            ListOfVgsCommands.Add("VVVS");
            ListOfVgsCommands.Add("VVVT");
            ListOfVgsCommands.Add("VVVW");
            ListOfVgsCommands.Add("VVVX");
            ListOfVgsCommands.Add("VVW");
            ListOfVgsCommands.Add("VVX");
            ListOfVgsCommands.Add("VVY");
            ListOfVgsCommands.Add("VXW");
            ListOfVgsCommands.Add("VXD");
            ListOfVgsCommands.Add("VXC");
            ListOfVgsCommands.Add("VXS");
            ListOfVgsCommands.Add("VXF");
            ListOfVgsCommands.Add("VXG");
            ListOfVgsCommands.Add("VXE");
            #endregion
            #region RAW
            //VA1
            //VA2
            //VA3
            //VAA
            //VAF
            //VAG
            //VAM
            //VAT1
            //VAT2
            //VAT3
            //VB1
            //VB2
            //VB3
            //VBA
            //VBB
            //VBD
            //VBE
            //VBF
            //VBG
            //VBJ1
            //VBJ3
            //VBJJ
            //VBM
            //VBS
            //VC1
            //VC2
            //VC3
            //VCB
            //VCC
            //VCJ
            //VD1
            //VD2
            //VD3
            //VDD
            //VDF
            //VDG
            //VDM
            //VEA
            //VEG
            //VEJ
            //VEL
            //VER
            //VET
            //VEW
            //VF1
            //VF2
            //VF3
            //VFF
            //VG1
            //VG2
            //VG3
            //VGG
            //VH1
            //VH2
            //VH3
            //VHH
            //VHS
            //VI1
            //VI2
            //VI3
            //VII
            //VQ1
            //VQ2
            //VQ3
            //VQF
            //VQG
            //VQN
            //VQQ
            //VR1
            //VR2
            //VR3
            //VRJ
            //VRR
            //VRS
            //VSA1
            //VSA2
            //VSA3
            //VSAA
            //VSAF
            //VSAG
            //VSAM
            //VSBB
            //VSBN
            //VSBT
            //VSD1
            //VSD2
            //VSD3
            //VSDD
            //VSDF
            //VSDG
            //VSDM
            //VSG1
            //VSG2
            //VSG3
            //VSGG
            //VSO
            //VSQ1
            //VSQ2
            //VSQ3
            //VSQQ
            //VSR
            //VSS
            //VST1
            //VST2
            //VST3
            //VSTB
            //VSTT
            //VT1
            //VT2
            //VT3
            //VTT
            //VVA
            //VVB
            //VVC
            //VVGB
            //VVGF
            //VVGG
            //VVGH
            //VVGL
            //VVGN
            //VVGO
            //VVGQ
            //VVGR
            //VVGS
            //VVGT
            //VVGW
            //VVK
            //VVM
            //VVN
            //VVP
            //VVS
            //VVT
            //VVVA
            //VVVB
            //VVVC
            //VVVD
            //VVVE
            //VVVF
            //VVVG
            //VVVJ
            //VVVP
            //VVVR
            //VVVS
            //VVVT
            //VVVW
            //VVVX
            //VVW
            //VVX
            //VVY
            //VXW
            //VXD
            //VXC
            //VXS
            //VXF
            //VXG
            //VXE
            #endregion
            #endregion
            #region ListOfAllDifferentCharsUsedForAllThePossibleVgsCommands
            //same but as a char
            ListOfAllDifferentCharsUsedForAllThePossibleVgsCommands = new List<char>(String.Join(string.Empty, ListOfVgsCommands).Distinct());
            //same but as a string
            ListOfAllDifferentCharsUsedForAllThePossibleVgsCommands_ToString = new List<string>();
            foreach (char c in ListOfAllDifferentCharsUsedForAllThePossibleVgsCommands)
            {
                ListOfAllDifferentCharsUsedForAllThePossibleVgsCommands_ToString.Add(c.ToString());
            }
            #endregion
        }
        /// <summary>
        /// First bool represent if the beginning of the command is valid, second bool represent if the command is valid and complete (3 or 4 characters total)
        /// </summary>
        /// <param name="vgs"></param>
        /// <returns></returns>
        public static Tuple<bool, bool> IsValid(string vgs)
        {
            return new Tuple<bool, bool>
                (
                    ListOfVgsCommands.Any(v => v.StartsWith(vgs)),
                    ListOfVgsCommands.Exists(vv => vv == vgs)
                );
        }
        /// <summary>
        /// SOURCE :<para/>
        /// https://stackoverflow.com/questions/630803/associating-enums-with-strings-in-c-sharp
        /// <para/>//VA123FGMTBDEJSCLRWHIQNOKPXY
        /// </summary>
        public class Key
        {
            private Key(int valueInt_, string valueString_, Keys valueKey_)
            {
                ValueInt    = valueInt_;
                ValueString = valueString_;
                ValueKey    = valueKey_;
            }

            public int ValueInt { get; set; }
            public string ValueString { get; set; }
            public Keys ValueKey { get; set; }

            #region Keys
            public static Key _01_V { get { return new Key(1, "V", Keys.V); } }
            public static Key _02_A { get { return new Key(2, "A", Keys.A); } }
            public static Key _03_1 { get { return new Key(3, "1", Keys.D1); } }
            public static Key _04_2 { get { return new Key(4, "2", Keys.D2); } }
            public static Key _05_3 { get { return new Key(5, "3", Keys.D3); } }
            public static Key _06_F { get { return new Key(6, "F", Keys.F); } }
            public static Key _07_G { get { return new Key(7, "G", Keys.G); } }
            public static Key _08_M { get { return new Key(8, "M", Keys.M); } }
            public static Key _09_T { get { return new Key(9, "T", Keys.T); } }
            public static Key _10_B { get { return new Key(10, "B", Keys.B); } }
            public static Key _11_D { get { return new Key(11, "D", Keys.D); } }
            public static Key _12_E { get { return new Key(12, "E", Keys.E); } }
            public static Key _13_J { get { return new Key(13, "J", Keys.J); } }
            public static Key _14_S { get { return new Key(14, "S", Keys.S); } }
            public static Key _15_C { get { return new Key(15, "C", Keys.C); } }
            public static Key _16_L { get { return new Key(16, "L", Keys.L); } }
            public static Key _17_R { get { return new Key(17, "R", Keys.R); } }
            public static Key _18_W { get { return new Key(18, "W", Keys.W); } }
            public static Key _19_H { get { return new Key(19, "H", Keys.H); } }
            public static Key _20_I { get { return new Key(20, "I", Keys.I); } }
            public static Key _21_Q { get { return new Key(21, "Q", Keys.Q); } }
            public static Key _22_N { get { return new Key(22, "N", Keys.N); } }
            public static Key _23_O { get { return new Key(23, "O", Keys.O); } }
            public static Key _24_K { get { return new Key(24, "K", Keys.K); } }
            public static Key _25_P { get { return new Key(25, "P", Keys.P); } }
            public static Key _26_X { get { return new Key(26, "X", Keys.X); } }
            public static Key _27_Y { get { return new Key(27, "Y", Keys.Y); } }
            #endregion

            public static explicit operator Key(Keys k)
            {
                switch (k)
                {
                    case Keys.V:  return _01_V;
                    case Keys.A:  return _02_A;
                    case Keys.D1: return _03_1;
                    case Keys.D2: return _04_2;
                    case Keys.D3: return _05_3;

                    case Keys.NumPad1: return _03_1;
                    case Keys.NumPad2: return _04_2;
                    case Keys.NumPad3: return _05_3;

                    case Keys.F:  return _06_F;
                    case Keys.G:  return _07_G;
                    case Keys.M:  return _08_M;
                    case Keys.T:  return _09_T;
                    case Keys.B:  return _10_B;
                    case Keys.D:  return _11_D;
                    case Keys.E:  return _12_E;
                    case Keys.J:  return _13_J;
                    case Keys.S:  return _14_S;
                    case Keys.C:  return _15_C;
                    case Keys.L:  return _16_L;
                    case Keys.R:  return _17_R;
                    case Keys.W:  return _18_W;
                    case Keys.H:  return _19_H;
                    case Keys.I:  return _20_I;
                    case Keys.Q:  return _21_Q;
                    case Keys.N:  return _22_N;
                    case Keys.O:  return _23_O;
                    case Keys.K:  return _24_K;
                    case Keys.P:  return _25_P;
                    case Keys.X:  return _26_X;
                    case Keys.Y:  return _27_Y;
                    default:      return null;
                }
            }
        }
    }
}
