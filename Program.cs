using System;
using System.Text;
using System.IO;

class Program {
    static void Main() {
        try {
            Console.WriteLine(@"Console Text
        
1. Start
2. How to use
3. About
4. Exit
            ");
            Console.Write("Enter your option: ");
            int n = int.Parse(Console.ReadLine());
            switch(n) {
                case 1: Console.Clear(); Start(); break;
                case 2: Console.Clear(); HowToUse(); break;
                case 3: About(); break;
                case 4: Environment.Exit(0); break;
                default: throw new Exception();
            }
        }
        catch(Exception) {
            Console.Clear();
            Console.WriteLine("Invalid command");
            Main();
        }
    }
    
    static void Start() {
        try {
            //var
            int mode = 0;
            string t;
            char[] a;
            char c;

            //func
            Console.WriteLine("Console Text");
            Console.Write("Enter your text: ");
            t = Console.ReadLine();
            a = t.ToCharArray();
            Console.Write("Enter character: ");
            c = char.Parse(Console.ReadLine());
            string[][] sa = Convert(a, c);
            StringBuilder sb = new();
            Console.WriteLine();
            for (int i = 0; i < 7; i++) {
                for (int j = 0; j < a.Length; j++) {
                    sb.Append(sa[j][i] + " ");
                }
                sb.AppendLine();
            }
            ToFile(t, sb, c, mode);
        }
        catch(Exception) {
            Console.Clear();
            Console.WriteLine("Invalid command");
            Main();
        }
    }

    static void ToFile(string t, StringBuilder sb, char c, int mode)
    {
        if (!Directory.Exists(@"extract")) Directory.CreateDirectory(@"extract");
        string filepath = DateTime.Now.ToString().Replace('/', '-').Replace(' ', '-').Replace(':', '-');
        Directory.CreateDirectory(@$"extract\{filepath}");
        File.Create(@$"extract\{filepath}\{filepath}.txt").Close();
        File.AppendAllText(@$"extract\{filepath}\{filepath}.txt", $"Text input: {t}\nChar input: {c}\n\n{sb.ToString()}");
        Console.Clear();
        System.Diagnostics.Process.Start("notepad.exe", @$"extract\{filepath}\{filepath}.txt");
        Console.WriteLine("Completed! Returning to main menu in 3 seconds...");
        System.Threading.Thread.Sleep(3000);
        Console.Clear();
        Main();
    }

    static string[][] Convert(char[] a, char c) {
        //array initialize
        string[][] convert = new string[a.Length][];
        for (int i = 0; i < a.Length; i++) {
            convert[i] = new string[7];
        }

        //add char
        for(int i = 0; i < a.Length; i++) {
            switch(a[i]) {
                #region a-z
                #region a
                case 'a': 
                    convert[i][0] = $"    "; 
                    convert[i][1] = $"    ";  
                    convert[i][2] = $" {c}{c} ";      //  ##
                    convert[i][3] = $"{c}  {c}";      // #  #
                    convert[i][4] = $" {c}{c}{c}";    //  ###
                    convert[i][5] = $"    ";
                    convert[i][6] = $"    ";
                    break;
                #endregion
                #region b
                case 'b': 
                    convert[i][0] = $"    ";       
                    convert[i][1] = $"{c}   ";        // #
                    convert[i][2] = $"{c}{c}{c} ";    // ###
                    convert[i][3] = $"{c}  {c}";      // #  #
                    convert[i][4] = $" {c}{c} ";      //  ##
                    convert[i][5] = $"    ";
                    convert[i][6] = $"    ";
                    break;
                #endregion
                #region c
                case 'c':
                    convert[i][0] = $"   ";
                    convert[i][1] = $"   ";
                    convert[i][2] = $" {c}{c}";       //  ##
                    convert[i][3] = $"{c}  ";         // #
                    convert[i][4] = $" {c}{c}";       //  ##
                    convert[i][5] = $"   ";
                    convert[i][6] = $"   ";
                    break;
                #endregion
                #region d
                case 'd':
                    convert[i][0] = $"    ";       
                    convert[i][1] = $"   {c}";        //    #
                    convert[i][2] = $" {c}{c}{c}";    //  ###
                    convert[i][3] = $"{c}  {c}";      // #  #
                    convert[i][4] = $" {c}{c} ";      //  ##
                    convert[i][5] = $"    ";
                    convert[i][6] = $"    ";
                    break;
                #endregion
                #region e
                case 'e':
                    convert[i][0] = $"    ";
                    convert[i][1] = $"    ";      
                    convert[i][2] = $" {c}{c}{c}";    //  ###
                    convert[i][3] = $"{c}{c}{c} ";    // ###
                    convert[i][4] = $" {c}{c}{c}";    //  ###
                    convert[i][5] = $"    ";
                    convert[i][6] = $"    ";
                    break;
                #endregion
                #region f
                case 'f':
                    convert[i][0] = $"   ";
                    convert[i][1] = $" {c}{c}";      //  ##
                    convert[i][2] = $"{c}  ";        // #
                    convert[i][3] = $"{c}{c}{c}";    // ###
                    convert[i][4] = $"{c}  ";        // #
                    convert[i][5] = $"{c}  ";        // #
                    convert[i][6] = $"   ";
                    break;
                #endregion
                #region g
                case 'g': 
                    convert[i][0] = $"    ";
                    convert[i][1] = $"    ";
                    convert[i][2] = $" {c}{c}{c}";   //  ###
                    convert[i][3] = $"{c}  {c}";     // #  # 
                    convert[i][4] = $" {c}{c}{c}";   //  ###
                    convert[i][5] = $"   {c}";       //    #
                    convert[i][6] = $" {c}{c} ";     //  ##
                    break;
                #endregion
                #region h
                case 'h':
                    convert[i][0] = $"    ";      
                    convert[i][1] = $"{c}   ";       // #
                    convert[i][2] = $"{c}{c}{c} ";   // ###
                    convert[i][3] = $"{c}  {c}";     // #  #
                    convert[i][4] = $"{c}  {c}";     // #  #
                    convert[i][5] = $"    ";
                    convert[i][6] = $"    ";
                    break;
                #endregion
                #region i
                case 'i':
                    convert[i][0] = $"{c}";          // #
                    convert[i][1] = $" ";            //
                    convert[i][2] = $"{c}";          // #
                    convert[i][3] = $"{c}";          // #
                    convert[i][4] = $"{c}";          // #
                    convert[i][5] = $" ";
                    convert[i][6] = $" ";
                    break;
                #endregion
                #region j
                case 'j':
                    convert[i][0] = $"  {c}";       //   #
                    convert[i][1] = $"   ";         //
                    convert[i][2] = $"  {c}";       //   #
                    convert[i][3] = $"  {c}";       //   #
                    convert[i][4] = $"{c} {c}";     // # #
                    convert[i][5] = $" {c} ";       //  #
                    convert[i][6] = $"   ";
                    break;
                #endregion
                #region k
                case 'k':
                    convert[i][0] = $"   ";
                    convert[i][1] = $"{c}  ";        // #
                    convert[i][2] = $"{c} {c}";      // # #
                    convert[i][3] = $"{c}{c} ";      // ##
                    convert[i][4] = $"{c} {c}";      // # #
                    convert[i][5] = $"   ";
                    convert[i][6] = $"   ";
                    break;
                #endregion
                #region l
                case 'l':
                    convert[i][0] = $"   ";
                    convert[i][1] = $"{c}{c} ";      // ##
                    convert[i][2] = $" {c} ";        //  #
                    convert[i][3] = $" {c} ";        //  #
                    convert[i][4] = $"{c}{c}{c}";    // ###
                    convert[i][5] = $"   ";
                    convert[i][6] = $"   ";
                    break;
                #endregion
                #region m
                case 'm':
                    convert[i][0] = $"       ";
                    convert[i][1] = $"       ";
                    convert[i][2] = $" {c}{c} {c}{c} ";      //  # #
                    convert[i][3] = $"{c}  {c}  {c}";        // # # #
                    convert[i][4] = $"{c}  {c}  {c}";        // # # #
                    convert[i][5] = $"       ";
                    convert[i][6] = $"       ";
                    break;
                #endregion
                #region n
                case 'n':
                    convert[i][0] = $"     ";
                    convert[i][1] = $"     ";
                    convert[i][2] = $" {c}{c}{c} ";  //  ###
                    convert[i][3] = $"{c}   {c}";    // #   #
                    convert[i][4] = $"{c}   {c}";    // #   #
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region o
                case 'o':
                    convert[i][0] = $"    ";
                    convert[i][1] = $"    ";
                    convert[i][2] = $" {c}{c} ";      //  ##  
                    convert[i][3] = $"{c}  {c}";      // #  #
                    convert[i][4] = $" {c}{c} ";      //  ##
                    convert[i][5] = $"    ";
                    convert[i][6] = $"    ";
                    break;
                #endregion
                #region p
                case 'p':
                    convert[i][0] = $"    ";
                    convert[i][1] = $"    ";
                    convert[i][2] = $" {c}{c} ";      //  ## 
                    convert[i][3] = $"{c}  {c}";      // #  #
                    convert[i][4] = $"{c}{c}{c} ";    // ###
                    convert[i][5] = $"{c}   ";        // #
                    convert[i][6] = $"    ";        
                    break;
                #endregion
                #region q
                case 'q':
                    convert[i][0] = $"    ";
                    convert[i][1] = $"    ";
                    convert[i][2] = $" {c}{c} ";      //  ## 
                    convert[i][3] = $"{c}  {c}";      // #  #
                    convert[i][4] = $" {c}{c}{c}";    //  ###
                    convert[i][5] = $"   {c}";        //    #
                    convert[i][6] = $"    ";        
                    break;
                #endregion
                #region r
                case 'r':
                    convert[i][0] = $"   ";
                    convert[i][1] = $"   ";
                    convert[i][2] = $" {c}{c}";       //  ##
                    convert[i][3] = $"{c}  ";         // #
                    convert[i][4] = $"{c}  ";         // #
                    convert[i][5] = $"   ";
                    convert[i][6] = $"   ";
                    break;
                #endregion
                #region s
                case 's':
                    convert[i][0] = $"   ";
                    convert[i][1] = $"   ";
                    convert[i][2] = $" {c}{c}";       //  ##
                    convert[i][3] = $" {c} ";         //  #
                    convert[i][4] = $"{c}{c} ";       // ##
                    convert[i][5] = $"   ";
                    convert[i][6] = $"   ";
                    break;
                #endregion
                #region t
                case 't':
                    convert[i][0] = $"   ";
                    convert[i][1] = $" {c} ";          //  #
                    convert[i][2] = $"{c}{c}{c}";      // ###
                    convert[i][3] = $" {c} ";          //  #
                    convert[i][4] = $" {c}{c}";        //  ##
                    convert[i][5] = $"   ";
                    convert[i][6] = $"   ";
                    break; 
                #endregion
                #region u
                case 'u':
                    convert[i][0] = $"    ";
                    convert[i][1] = $"    ";
                    convert[i][2] = $"{c}  {c}";        // #  #
                    convert[i][3] = $"{c}  {c}";        // #  #
                    convert[i][4] = $" {c}{c} ";        //  ##
                    convert[i][5] = $"    ";
                    convert[i][6] = $"    ";
                    break;
                #endregion
                #region v
                case 'v':
                    convert[i][0] = $"     ";
                    convert[i][1] = $"     ";
                    convert[i][2] = $"{c}   {c}";       // #   #
                    convert[i][3] = $" {c} {c} ";       //  # #
                    convert[i][4] = $"  {c}  ";         //   #
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region w
                case 'w':
                    convert[i][0] = $"     ";
                    convert[i][1] = $"     ";
                    convert[i][2] = $"{c} {c} {c}";     // # # #
                    convert[i][3] = $"{c} {c} {c}";     // # # #
                    convert[i][4] = $" {c} {c} ";       //  # #
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region x
                case 'x':
                    convert[i][0] = $"   ";
                    convert[i][1] = $"   ";
                    convert[i][2] = $"{c} {c}";          // # #
                    convert[i][3] = $" {c} ";            //  #
                    convert[i][4] = $"{c} {c}";          // # #
                    convert[i][5] = $"   ";
                    convert[i][6] = $"   ";
                    break;
                #endregion
                #region y
                case 'y':
                    convert[i][0] = $"     ";
                    convert[i][1] = $"     ";
                    convert[i][2] = $"{c}   {c}";       // #   #
                    convert[i][3] = $" {c} {c} ";       //  # #
                    convert[i][4] = $"  {c}  ";         //   #
                    convert[i][5] = $" {c}   ";         //  #
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region z
                case 'z':
                    convert[i][0] = $"   ";
                    convert[i][1] = $"   ";
                    convert[i][2] = $"{c}{c} ";          // ##
                    convert[i][3] = $" {c} ";            //  #
                    convert[i][4] = $" {c}{c}";         //  ##
                    convert[i][5] = $"   ";
                    convert[i][6] = $"   ";
                    break;
                #endregion
                #endregion
                #region A-Z
                #region A
                case 'A':
                    convert[i][0] = $"    {c}    ";                    //     #
                    convert[i][1] = $"   {c} {c}   ";                  //    # #
                    convert[i][2] = $"  {c}{c}{c}{c}{c}  ";            //   #####
                    convert[i][3] = $" {c}     {c} ";                  //  #     #
                    convert[i][4] = $"{c}       {c}";                  // #       #
                    convert[i][5] = $"         ";
                    convert[i][6] = $"         ";
                    break;
                #endregion
                #region B
                case 'B':
                    convert[i][0] = $"{c}{c}{c}{c} ";                  // ####
                    convert[i][1] = $"{c}   {c}";                      // #   #
                    convert[i][2] = $"{c}{c}{c}{c} ";                  // ####
                    convert[i][3] = $"{c}   {c}";                      // #   #
                    convert[i][4] = $"{c}{c}{c}{c} ";                  // ####
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region C
                case 'C': 
                    convert[i][0] = $" {c}{c}{c}{c}";                  //  ####
                    convert[i][1] = $"{c}    ";                        // #
                    convert[i][2] = $"{c}    ";                        // #
                    convert[i][3] = $"{c}    ";                        // #
                    convert[i][4] = $" {c}{c}{c}{c}";                  //  ####
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region D
                case 'D': 
                    convert[i][0] = $"{c}{c}{c}{c} ";                  // ####
                    convert[i][1] = $"{c}   {c}";                      // #   #
                    convert[i][2] = $"{c}   {c}";                      // #   #
                    convert[i][3] = $"{c}   {c}";                      // #   #
                    convert[i][4] = $"{c}{c}{c}{c} ";                  // ####
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region E
                case 'E':
                    convert[i][0] = $" {c}{c}{c}{c}";                  //  ####
                    convert[i][1] = $"{c}    ";                        // #
                    convert[i][2] = $" {c}{c}{c}{c}";                  //  ####
                    convert[i][3] = $"{c}    ";                        // #
                    convert[i][4] = $" {c}{c}{c}{c}";                  //  ####
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region F
                case 'F':
                    convert[i][0] = $"{c}{c}{c}{c}{c}";                // #####
                    convert[i][1] = $"{c}    ";                        // #
                    convert[i][2] = $"{c}{c}{c}{c} ";                 // ####
                    convert[i][3] = $"{c}    ";                        // #
                    convert[i][4] = $"{c}    ";                        // #
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region G
                case 'G':
                    convert[i][0] = $" {c}{c}{c}{c}";                  //  ####
                    convert[i][1] = $"{c}    ";                        // #
                    convert[i][2] = $"{c} {c}{c}{c}";                  // # ###
                    convert[i][3] = $"{c}   {c}";                      // #   #
                    convert[i][4] = $" {c}{c}{c} ";                    //  ###
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region H
                case 'H':
                    convert[i][0] = $"{c}   {c}";                      // #   #
                    convert[i][1] = $"{c}   {c}";                      // #   #
                    convert[i][2] = $"{c}{c}{c}{c}{c}";                // #####
                    convert[i][3] = $"{c}   {c}";                      // #   #
                    convert[i][4] = $"{c}   {c}";                      // #   #
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region I
                case 'I':
                    convert[i][0] = $"{c}{c}{c}{c}{c}";                // #####
                    convert[i][1] = $"  {c}  ";                        //   #
                    convert[i][2] = $"  {c}  ";                        //   #
                    convert[i][3] = $"  {c}  ";                        //   #
                    convert[i][4] = $"{c}{c}{c}{c}{c}";                // #####
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region J
                case 'J':
                    convert[i][0] = $"{c}{c}{c}{c}{c}";                // #####
                    convert[i][1] = $"    {c}";                        //     #
                    convert[i][2] = $"    {c}";                        //     #
                    convert[i][3] = $"{c}   {c}";                      // #   #
                    convert[i][4] = $" {c}{c}{c} ";                    //  ###
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region K
                case 'K':
                    convert[i][0] = $"{c}   {c}";                      // #   #
                    convert[i][1] = $"{c}  {c} ";                      // #  #
                    convert[i][2] = $"{c}{c}{c}  ";                    // ###
                    convert[i][3] = $"{c}  {c} ";                      // #  #
                    convert[i][4] = $"{c}   {c}";                      // #   #
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region L
                case 'L':
                    convert[i][0] = $"{c}    ";                        // #
                    convert[i][1] = $"{c}    ";                        // #
                    convert[i][2] = $"{c}    ";                        // #
                    convert[i][3] = $"{c}    ";                        // #
                    convert[i][4] = $" {c}{c}{c}{c}";                  //  ####
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region M
                case 'M':
                    convert[i][0] = $"{c}     {c}";                    // #     #
                    convert[i][1] = $"{c}{c}   {c}{c}";                // ##   ##
                    convert[i][2] = $"{c} {c} {c} {c}";                // # # # #
                    convert[i][3] = $"{c}  {c}  {c}";                  // #  #  #
                    convert[i][4] = $"{c}     {c}";                    // #     #
                    convert[i][5] = $"       ";
                    convert[i][6] = $"       ";
                    break;
                #endregion
                #region N
                case 'N':
                    convert[i][0] = $"{c}   {c}";                      // #   #
                    convert[i][1] = $"{c}{c}  {c}";                    // ##  #
                    convert[i][2] = $"{c} {c} {c}";                    // # # #
                    convert[i][3] = $"{c}  {c}{c}";                    // #  ##
                    convert[i][4] = $"{c}   {c}";                      // #   #
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region O
                case 'O':
                    convert[i][0] = $" {c}{c}{c} ";                    //  ###
                    convert[i][1] = $"{c}   {c}";                      // #   #
                    convert[i][2] = $"{c}   {c}";                      // #   #
                    convert[i][3] = $"{c}   {c}";                      // #   #
                    convert[i][4] = $" {c}{c}{c} ";                    //  ###
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region P
                case 'P':
                    convert[i][0] = $" {c}{c}{c} ";                    //  ###
                    convert[i][1] = $"{c}   {c}";                      // #   #
                    convert[i][2] = $"{c}{c}{c}{c} ";                  // ####
                    convert[i][3] = $"{c}    ";                        // #
                    convert[i][4] = $"{c}    ";                        // #
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region Q
                case 'Q':
                    convert[i][0] = $" {c}{c}{c} ";                    //  ###
                    convert[i][1] = $"{c}   {c}";                      // #   #
                    convert[i][2] = $"{c} {c} {c}";                    // # # #
                    convert[i][3] = $"{c}  {c}{c}";                    // #  ##
                    convert[i][4] = $" {c}{c}{c}{c}";                  //  ####
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region R
                case 'R':
                    convert[i][0] = $"{c}{c}{c}{c} ";                  // ####
                    convert[i][1] = $"{c}   {c}";                      // #   #
                    convert[i][2] = $"{c}{c}{c}{c} ";                  // ####
                    convert[i][3] = $"{c}   {c}";                      // #   #
                    convert[i][4] = $"{c}   {c}";                      // #   #
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region S
                case 'S':
                    convert[i][0] = $"  {c}{c}{c}";                    //   ###
                    convert[i][1] = $" {c}   ";                        //  #
                    convert[i][2] = $"  {c}  ";                        //   #
                    convert[i][3] = $"   {c} ";                        //    #
                    convert[i][4] = $"{c}{c}{c}  ";                    // ###
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region T
                case 'T':
                    convert[i][0] = $"{c}{c}{c}{c}{c}";                // #####
                    convert[i][1] = $"  {c}  ";                        //   #
                    convert[i][2] = $"  {c}  ";                        //   #
                    convert[i][3] = $"  {c}  ";                        //   #
                    convert[i][4] = $"  {c}  ";                        //   #
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region U
                case 'U':
                    convert[i][0] = $"{c}   {c}";                      // #   #
                    convert[i][1] = $"{c}   {c}";                      // #   #
                    convert[i][2] = $"{c}   {c}";                      // #   #
                    convert[i][3] = $"{c}   {c}";                      // #   #
                    convert[i][4] = $" {c}{c}{c} ";                    //  ###
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region V
                case 'V':
                    convert[i][0] = $"{c}       {c}";                  // #       #
                    convert[i][1] = $" {c}     {c} ";                  //  #     #
                    convert[i][2] = $"  {c}   {c}  ";                  //   #   #
                    convert[i][3] = $"   {c} {c}   ";                  //    # # 
                    convert[i][4] = $"    {c}    ";                    //     #
                    convert[i][5] = $"         ";
                    convert[i][6] = $"         ";
                    break;
                #endregion
                #region W
                case 'W':
                    convert[i][0] = $"{c}  {c}  {c}";                  // #  #  #
                    convert[i][1] = $"{c}  {c}  {c}";                  // #  #  #
                    convert[i][2] = $"{c}  {c}  {c}";                  // #  #  #
                    convert[i][3] = $"{c}  {c}  {c}";                  //  ## ##
                    convert[i][4] = $" {c}{c} {c}{c} ";
                    convert[i][5] = $"       ";
                    convert[i][6] = $"       ";
                    break;
                #endregion
                #region X
                case 'X':
                    convert[i][0] = $"{c}   {c}";                      // #   #
                    convert[i][1] = $" {c} {c} ";                      //  # #
                    convert[i][2] = $"  {c}  ";                        //   #
                    convert[i][3] = $" {c} {c} ";                      //  # #
                    convert[i][4] = $"{c}   {c}";                      // #   #
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region Y
                case 'Y':
                    convert[i][0] = $"{c}   {c}";                      // #   #
                    convert[i][1] = $" {c} {c} ";                      //  # #
                    convert[i][2] = $"  {c}  ";                        //   #
                    convert[i][3] = $"  {c}  ";                        //   #
                    convert[i][4] = $"  {c}  ";                        //   #
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region Z
                case 'Z':
                    convert[i][0] = $"{c}{c}{c}  ";                    // ###
                    convert[i][1] = $"   {c} ";                        //    #
                    convert[i][2] = $"  {c}  ";                        //   #
                    convert[i][3] = $" {c}   ";                        //  #
                    convert[i][4] = $"  {c}{c}{c}";                    //   ###
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #endregion
                #region 0-9
                #region 1
                case '1': 
                    convert[i][0] = $"  {c}  ";                 //   #
                    convert[i][1] = $" {c}{c}  ";               //  ##
                    convert[i][2] = $"  {c}  ";                 //   #
                    convert[i][3] = $"  {c}  ";                 //   #
                    convert[i][4] = $"{c}{c}{c}{c}{c}";         // #####
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region 2
                case '2':
                    convert[i][0] = $" {c}{c}{c} ";             //  ###
                    convert[i][1] = $"    {c}";                 //     #
                    convert[i][2] = $" {c}{c}{c} ";             //  ###
                    convert[i][3] = $"{c}    ";                 // #
                    convert[i][4] = $" {c}{c}{c} ";             //  ###
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region 3
                case '3':
                    convert[i][0] = $"{c}{c}{c} ";              // ###
                    convert[i][1] = $"   {c}";                  //    #
                    convert[i][2] = $"{c}{c}{c} ";              // ###
                    convert[i][3] = $"   {c}";                  //    #
                    convert[i][4] = $"{c}{c}{c} ";              // ###
                    convert[i][5] = $"    ";
                    convert[i][6] = $"    ";
                    break;
                #endregion
                #region 4
                case '4':
                    convert[i][0] = $"   {c} ";                 //    #
                    convert[i][1] = $"  {c}{c} ";               //   ##
                    convert[i][2] = $" {c} {c} ";               //  # #
                    convert[i][3] = $"{c}{c}{c}{c}{c}";         // #####
                    convert[i][4] = $"   {c} ";                 //    #
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region 5
                case '5':
                    convert[i][0] = $" {c}{c}{c} ";             //  ###
                    convert[i][1] = $"{c}    ";                 // #
                    convert[i][2] = $" {c}{c}{c} ";             //  ###
                    convert[i][3] = $"    {c}";                 //     #
                    convert[i][4] = $" {c}{c}{c} ";             //  ###
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region 6
                case '6':
                    convert[i][0] = $" {c}{c}{c} ";             //  ###
                    convert[i][1] = $"{c}    ";                 // #
                    convert[i][2] = $"{c}{c}{c}{c} ";           // ####
                    convert[i][3] = $"{c}   {c}";               // #   #
                    convert[i][4] = $" {c}{c}{c} ";             //  ###
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region 7
                case '7':
                    convert[i][0] = $"{c}{c}{c}{c}{c}";         // #####
                    convert[i][1] = $"    {c}";                 //     #
                    convert[i][2] = $"   {c} ";                 //    #
                    convert[i][3] = $"  {c}  ";                 //   #
                    convert[i][4] = $" {c}   ";                 //  #
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region 8
                case '8':
                    convert[i][0] = $" {c}{c}{c} ";             //  ###
                    convert[i][1] = $"{c}   {c}";               // #   #
                    convert[i][2] = $" {c}{c}{c} ";             //  ###
                    convert[i][3] = $"{c}   {c}";               // #   #
                    convert[i][4] = $" {c}{c}{c} ";             //  ###
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region 9
                case '9':
                    convert[i][0] = $" {c}{c}{c} ";             //  ###
                    convert[i][1] = $"{c}   {c}";               // #   #
                    convert[i][2] = $" {c}{c}{c}{c}";           //  ####
                    convert[i][3] = $"    {c}";                 //     #
                    convert[i][4] = $" {c}{c}{c} ";             //  ###
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #region 0
                case '0':
                    convert[i][0] = $" {c}{c}{c} ";             //  ###
                    convert[i][1] = $"{c}  {c}{c}";             // #  ##
                    convert[i][2] = $"{c} {c} {c}";             // # # #
                    convert[i][3] = $"{c}{c}  {c}";             // ##  #
                    convert[i][4] = $" {c}{c}{c} ";             //  ###
                    convert[i][5] = $"     ";
                    convert[i][6] = $"     ";
                    break;
                #endregion
                #endregion
                #region special char (under development)
                #region space
                case ' ':
                    convert[i][0] = $" ";
                    convert[i][1] = $" ";
                    convert[i][2] = $" ";      
                    convert[i][3] = $" ";      
                    convert[i][4] = $" ";    
                    convert[i][5] = $" ";
                    convert[i][6] = $" ";
                    break;
                #endregion
                #endregion  
                default: break;
            }
        }
        return convert;
    }
    static void HowToUse() {
        Console.Clear();
        Console.WriteLine(@"Console Text
How To Use section is still under development! Press any key to go back to main menu");
        Console.ReadKey();
        Console.Clear();
        Main();
    }
    static void About() {
        Console.Clear();
        Console.WriteLine(@"Console Text
Version: v0.2 BETA
Made by domcvn

Press any key to go back to main menu...");
        Console.ReadKey();
        Console.Clear();
        Main();
    }
}
