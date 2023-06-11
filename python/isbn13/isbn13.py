class ISBN13:
    def __init__(self, isbn):
        self.isbn = isbn

    def is_valid(self) -> bool:
        # see https://en.wikipedia.org/wiki/ISBN#ISBN-13_check_digit_calculation
        if len(self.isbn) < 13:
            return False
        if len(self.isbn) > 13:
            return False
        if self.isbn[0] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn[1] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn[2] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn[3] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn[4] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn[5] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn[6] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn[7] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn[8] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn[9] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn[10] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn[11] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn[12] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if (
            int(self.isbn[0])
            + 3 * int(self.isbn[1])
            + int(self.isbn[2])
            + 3 * int(self.isbn[3])
            + int(self.isbn[4])
            + 3 * int(self.isbn[5])
            + int(self.isbn[6])
            + 3 * int(self.isbn[7])
            + int(self.isbn[8])
            + 3 * int(self.isbn[9])
            + int(self.isbn[10])
            + 3 * int(self.isbn[11])
            + int(self.isbn[12])
        ) % 10 == 0:
            return True
        else:
            return False
