using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TapeAbstract;

namespace PostMachine {
    class Tape : TapeA<Cell> {
        public Tape(Cell[] cells, int pos) : base(cells, pos) {
        }

        // Встановлення мітки
        public void Mark() {
            curr.setMark(true);
        }

        // Зняття мітки
        public void Unmark() {
            curr.setMark(false);
        }

        // Перевірка мітки
        public bool getMark() {
            return curr.getMark();
        }

        // Друк стрічки
        public override void print() {
            foreach (Cell c in cells) {
                Console.Write('|');
                Console.Write(c.getMark()?'V':' ');
            }
            Console.Write('|');
            Console.Write('\t');
        }

        // Друк головки
        public override void printHead() {
            foreach (Cell c in cells) {
                Console.Write(' ');
                Console.Write((c == curr)?'*':' ');
            }
            Console.WriteLine();
        }
    }
}
