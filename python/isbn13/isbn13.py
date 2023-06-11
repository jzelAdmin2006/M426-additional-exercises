class ISBN13:
    def __init__(self, isbn13):
        self.isbn13 = isbn13

    def is_valid(self) -> bool:
        # see https://en.wikipedia.org/wiki/ISBN#ISBN-13_check_digit_calculation
        if len(self.isbn13) < 13:
            return False
        if len(self.isbn13) > 13:
            return False
        if self.isbn13[0] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn13[1] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn13[2] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn13[3] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn13[4] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn13[5] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn13[6] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn13[7] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn13[8] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn13[9] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn13[10] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn13[11] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if self.isbn13[12] not in ["0", "1", "2", "3", "4", "5", "6", "7", "8", "9"]:
            return False
        if (
            int(self.isbn13[0])
            + 3 * int(self.isbn13[1])
            + int(self.isbn13[2])
            + 3 * int(self.isbn13[3])
            + int(self.isbn13[4])
            + 3 * int(self.isbn13[5])
            + int(self.isbn13[6])
            + 3 * int(self.isbn13[7])
            + int(self.isbn13[8])
            + 3 * int(self.isbn13[9])
            + int(self.isbn13[10])
            + 3 * int(self.isbn13[11])
            + int(self.isbn13[12])
        ) % 10 == 0:
            return True
        else:
            return False
