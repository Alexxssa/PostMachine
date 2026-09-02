using System;

namespace TuringMachine {
    class ProgramCell {
        public static readonly char[] M = { 'L', 'R', 'N' };
        public const int ML = 0;
        public const int MR = 1;
        public const int MN = 2;

        public int new_state;
        public int new_a;
        public int mi;

        public ProgramCell(int new_state, int new_a, int mi) {
            this.new_state = new_state;
            this.new_a = new_a;
            this.mi = mi;
        }

        // Друк елементу програми
        public void print(int state, int a) {
            Console.Write(String.Format("q{0:D2}_{1} -> q{2:D2}_{3}{4} ", state, Cell.A[a], new_state, Cell.A[new_a], M[mi]));
        }
    }
}
