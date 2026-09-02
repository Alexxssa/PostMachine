using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuringMachine {
    static class Program {
        static void Main(string[] args) {
            // Програма для машини Поста згідно варіанта
            ProgramA pra = new ProgramA(new ProgramCell[][] {
                // Перше додавання m+n
                // 0 Рухаємо праворуч до першої 1
                new ProgramCell[] { new ProgramCell(0, Cell.A_0, ProgramCell.MR), new ProgramCell(1, Cell.A_1, ProgramCell.MN), null, null, null },

                // 1 Рухаємо праворуч до +, (S) не встановлено
                new ProgramCell[] { null, new ProgramCell(2, Cell.A_S, ProgramCell.MR), new ProgramCell(3, Cell.A_P, ProgramCell.MR), null, null },
                // 2 Рухаємо праворуч до +, (S) встановлено
                new ProgramCell[] { null, new ProgramCell(2, Cell.A_1, ProgramCell.MR), new ProgramCell(4, Cell.A_P, ProgramCell.MR), null, null },

                // 3 Рухаємо праворуч до =, (S) не встановлено
                new ProgramCell[] { null, new ProgramCell(4, Cell.A_S, ProgramCell.MR), null, new ProgramCell(7, Cell.A_E, ProgramCell.ML), null },
                // 4 Рухаємо праворуч до =, (S) встановлено
                new ProgramCell[] { null, new ProgramCell(4, Cell.A_1, ProgramCell.MR), null, new ProgramCell(5, Cell.A_E, ProgramCell.MR), null },

                // 5 Рухаємо праворуч до 0, встановлюємо 1 
                new ProgramCell[] { new ProgramCell(6, Cell.A_1, ProgramCell.ML), new ProgramCell(5, Cell.A_1, ProgramCell.MR), null, null, null },
                // 6 Рухаємо ліворуч до =
                new ProgramCell[] { null, new ProgramCell(6, Cell.A_1, ProgramCell.ML), null, new ProgramCell(7, Cell.A_E, ProgramCell.ML), null },

                // 7 Рухаємо ліворуч до +, якщо S - відновлюемо 1 та у стан 4
                new ProgramCell[] { null, new ProgramCell(7, Cell.A_1, ProgramCell.ML), new ProgramCell(8, Cell.A_P, ProgramCell.ML), null, new ProgramCell(3, Cell.A_1, ProgramCell.MR) },
                // 8 Рухаємо ліворуч до 0, якщо S - відновлюемо 1 та у стан 2
                new ProgramCell[] {  new ProgramCell(9, Cell.A_0, ProgramCell.MR), new ProgramCell(8, Cell.A_1, ProgramCell.ML), null, null, new ProgramCell(1, Cell.A_1, ProgramCell.MR) },


                // Друге додавання m+(m+n)
                // 9 Рухаємо праворуч до першої 1
                new ProgramCell[] { new ProgramCell(9, Cell.A_0, ProgramCell.MR), new ProgramCell(10, Cell.A_1, ProgramCell.MN), null, null, null },
                // 10 Рухаємо праворуч до +, (S) не встановлено
                new ProgramCell[] { null, new ProgramCell(11, Cell.A_S, ProgramCell.MR), new ProgramCell(14, Cell.A_P, ProgramCell.ML), null, null },
                // 11 Рухаємо праворуч до +, (S) встановлено
                new ProgramCell[] { null, new ProgramCell(11, Cell.A_1, ProgramCell.MR), new ProgramCell(12, Cell.A_P, ProgramCell.MR), null, null },

                // 12 Рухаємо праворуч до 0, встановлюємо 1 
                new ProgramCell[] { new ProgramCell(13, Cell.A_1, ProgramCell.ML), new ProgramCell(12, Cell.A_1, ProgramCell.MR), null, new ProgramCell(12, Cell.A_E, ProgramCell.MR), null },

                // 13 Рухаємо ліворуч до +
                new ProgramCell[] { null, new ProgramCell(13, Cell.A_1, ProgramCell.ML), new ProgramCell(14, Cell.A_P, ProgramCell.ML), new ProgramCell(13, Cell.A_E, ProgramCell.ML), null },

                // 14 Рухаємо ліворуч до 0, якщо S - відновлюемо 1 та у стан 10
                new ProgramCell[] { null, new ProgramCell(14, Cell.A_1, ProgramCell.ML), null, null, new ProgramCell(10, Cell.A_1, ProgramCell.MR) },
            }, 0);

            // Початкове значення стрічки та положення згідно варіанта
            Tape tape = new Tape(new Cell[] {
                new Cell(),
                new Cell().set(Cell.A_1),
                new Cell().set(Cell.A_1),
                new Cell().set(Cell.A_P),
                new Cell().set(Cell.A_1),
                new Cell().set(Cell.A_1),
                new Cell().set(Cell.A_E),
                new Cell()
            }, 0);

            // Друк програми
            pra.printAll();

            // Перший запуск
            Console.WriteLine("Start:");
            bool work;
            do {
                tape.print(); pra.print(tape);
                tape.printHead();
                work = pra.getNextProgram(tape);
                Console.ReadKey();
            } while (work);
            Console.WriteLine();
            Console.ReadKey();
        }    
    }
}
