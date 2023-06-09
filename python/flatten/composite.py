from typing import Protocol

class Cell(Protocol):
    def get_left(self) -> 'Cell':
        pass

    def get_right(self) -> 'Cell':
        pass

class Value(Cell):
    def __init__(self, left: 'Value', right: Cell):
        self.left = left
        self.right = right
    
    def get_left(self) -> 'Value':
        return self.left
    
    def get_right(self) -> Cell:
        return self.right

class List(Cell):
    def __init__(self, left: 'List', right: 'List'):
        self.left = left
        self.right = right
    
    def get_left(self) -> 'List':
        return self.left
    
    def get_right(self) -> 'List':
        return self.right