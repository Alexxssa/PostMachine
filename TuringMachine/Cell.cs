namespace TuringMachine {
    public class Cell {
        public static readonly char[] A = { '0', '1', '+', '=', 'S' };
        public static readonly int A_0 = 0;
        public static readonly int A_1 = 1;
        public static readonly int A_P = 2;
        public static readonly int A_E = 3;
        public static readonly int A_S = 4;

        int ai = A_0;

        public Cell set(int i) {
            this.ai = i;
            return this;
        }

        public int get() {
            return ai;
        }
    }
}
