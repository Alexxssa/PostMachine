using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TapeAbstract;

namespace TuringMachine {
    class Tape : TapeA<Cell> {
        // Конструктор стрічки машини Тюрінга
        public Tape(Cell[] cells, int pos) : base(cells, pos) {
        }

        // Встановлення значення
        public void Set(int i) {
            curr.set(i);
        }

        // Перевірка значення
        public int Get() {
            return curr.get();
        }

        // Друк стрічки
        public override void print() {            
            var symbols = cells.Select(c => Cell.A[c.get()]);
            Console.Write("|" + string.Join("|", symbols) + "|\t");
        }

        // Друк головки
        public override void printHead() {
            /*
            int pos = cells.IndexOf(curr);
            String s = new String(' ',cells.Count).Remove(pos,1).Insert(pos,"*");
            Console.WriteLine(' ' + String.Join(" ",s.ToCharArray()));        
            */
            foreach (Cell c in cells) {
                Console.Write(' ');
                Console.Write((c == curr)?'*':' ');
            }
            Console.WriteLine();

        }
    }
}
