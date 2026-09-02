using System;

namespace PostMachine {
    static class Program {
        static void Main(string[] args) {
            // Програма для машини Поста згідно варіанта
            ProgramA pra = new ProgramA(new ProgramCell[] {
                new ProgramCell('R', 1),      // 0. Крок праворуч, перейти до команди 1
                new ProgramCell('?', 2, 0),   // 1. Якщо не мітка, перейти до кроку 2, інакше на 0
                new ProgramCell('V', 3),      // 2. Встановити мітку, перейти до кроку 3
                new ProgramCell('!'),         // 3. Кінець програми
            });

            // Початкове значення стрічки та положення згідно варіанта
            Tape tape = new Tape(new Cell[] {
                new Cell(),
                new Cell().setMark(true),
                new Cell().setMark(true),
                new Cell().setMark(true),
                new Cell().setMark(true),
                new Cell()
            }, 4);

            // Друк програми
            pra.printAll();

            // Перший запуск
            Console.WriteLine("Перший запуск:");
            bool work;
            do {
                tape.print(); pra.print();
                tape.printHead();
                work = pra.getNextProgram(tape);
            } while (work);
            Console.WriteLine();

            // Другий запуск - програму на початок
            Console.WriteLine("Другий запуск:");
            pra.begin();
            do {
                tape.print(); pra.print();
                tape.printHead();
                work = pra.getNextProgram(tape);
            } while (work);

            Console.ReadKey();
        }
    }
}
