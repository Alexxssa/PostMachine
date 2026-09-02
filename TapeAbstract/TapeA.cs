using System;
using System.Collections.Generic;

namespace TapeAbstract {
    public abstract class TapeA<T> where T : new() {
        protected readonly List<T> cells = new List<T>();
        protected T curr;

        // Конструктор стрічки машини Поста
        protected TapeA(T[] cells, int pos) {
            this.cells.AddRange(cells);
            curr = cells[pos];
        }

        // Рух ліворуч
        public void Left() {
            int pos = cells.IndexOf(curr);
            if (pos == 0) {
                curr = new T();
                cells.Insert(0, curr);
            }
            else {
                curr = cells[pos-1];
            }
        }

        // Рух праворуч
        public void Right() {
            int pos = cells.IndexOf(curr);
            if (pos == cells.Count-1) {
                curr = new T();
                cells.Add(curr);
            }
            else {
                curr = cells[pos+1];
            }
        }

        // Друк стрічки
        public abstract void print();

        // Друк головки
        public abstract void printHead();
    }
}
