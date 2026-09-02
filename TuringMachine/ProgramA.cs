using System;

namespace TuringMachine {
    class ProgramA {
        readonly ProgramCell[][] pr;   // Елементи програми (j - алфавіт, i - стан)
        int state;

        // Конструктор програми машини Тюрінга
        public ProgramA(ProgramCell[][] pr, int state) {
            this.pr = pr;
            this.state = state;
        }

        // Робота машини Тюринга
        public bool getNextProgram(Tape tape) {
            // Поточна програма по стану та значенню в комірці
            ProgramCell curr = pr[state][tape.Get()];
            if (curr != null) {
                // Новий стан з програми
                state = curr.new_state;
                // Нове значення з програми у комірку
                tape.Set(curr.new_a);
                // Зсув
                switch (curr.mi) {
                    //Зсув лыворуч
                    case ProgramCell.ML: tape.Left(); break;
                    // Зсув праворуч
                    case ProgramCell.MR: tape.Right(); break;
                    // На місці
                    case ProgramCell.MN: break;
                }
                return true;
            }
            else {
                return false;
            }
        }

        // Друк поточного елементу програми
        public void print(Tape tape) {
            int a = tape.Get();
            ProgramCell curr = pr[state][a];
            if (curr != null) {
                curr.print(state, a);
            }
            else {
                Console.Write("End");
            }
            Console.WriteLine();
        }

        // Друк усієї програми
        public void printAll() {
            Console.WriteLine("Програма: ");
            for (int i=0;i<pr.Length;i++) {
                Console.Write(String.Format("{0:D2}: ",i));
                for (int j=0; j<pr[i].Length;j++) {
                    ProgramCell p = pr[i][j];
                    if (p != null) {
                        p.print(i, j);
                    }
                    else {
                        Console.Write('\t');
                        Console.Write('\t');
                    }
                    Console.Write('\t');
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
