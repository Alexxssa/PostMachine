namespace PostMachine {
    class Cell {
        bool mark = false;

        public Cell setMark(bool mark) {
            this.mark = mark;
            return this;
        }

        public bool getMark() {
            return mark;
        }
    }
}
