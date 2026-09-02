using System;

namespace PostMachine {
    class ProgramCell {
        public char comm;    // 'V', 'X', 'L', 'R', '?'. '!' 
        public int s1, s2;   // Рядок команд

        public ProgramCell(char comm) {
            this.comm = comm;
        }

        public ProgramCell(char comm, int s1) {
            this.comm = comm;
            this.s1 = s1;
        }

        public ProgramCell(char comm, int s1, int s2) {
            this.comm = comm;
            this.s1 = s1;
            this.s2 = s2;
        }

        // Друк елементу програми
        public void print() {
            Console.Write(comm);
            switch (comm) {
                case '!': break;
                case '?': Console.Write(""+s1+','+s2); break;
                default: Console.Write(s1); break;
            }
        }
    }
}
