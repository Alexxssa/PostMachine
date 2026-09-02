using System;

namespace PostMachine {
    class ProgramA {
        readonly ProgramCell[] pr;   // Елементи програми
        int pos = 0;        // Поточний крок програми (з нуля)

        // Конструктор програми машини Поста
        public ProgramA(ProgramCell[] cells) {
            pr = cells;
        }

        // Робота машини Поста
        public bool getNextProgram(Tape tape) {
            ProgramCell pc = pr[pos];
            switch (pc.comm) {
                //Зсув лыворуч
                case 'L': tape.Left(); pos = pc.s1; break;
                // Зсув праворуч
                case 'R': tape.Right(); pos = pc.s1; break;
                // Поставити мітку
                case 'V': tape.Mark(); pos = pc.s1; break;
                // Зняти мітку
                case 'X': tape.Unmark(); pos = pc.s1; break;
                // Перехід за умовою
                case '?': if (tape.getMark()) { pos = pc.s2; }  else { pos = pc.s1; }  break;
                // Кінець програми
                case '!': return false;
            }
            return true;
        }

        // Встановлення програми на початок
        public void begin() {
            pos = 0;
        }

        // Друк поточного елементу програми
        public void print() {
            pr[pos].print();
            Console.WriteLine();
        }

        // Друк усієї програми
        public void printAll() {
            Console.Write("Програма: ");
            int i=0;
            foreach (ProgramCell p in pr) {
                Console.Write(""+i+'.');
                p.print();
                Console.Write(' ');
                i++;
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
