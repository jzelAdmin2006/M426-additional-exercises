from typing import Protocol


class Node(Protocol):
    pass


class Value(Node):
    def __init__(self, value: int):
        self.val: int = value

    def __str__(self) -> str:
        return str(self.val)


class List(Node):
    def __init__(self, items: list[Node]):
        self.items: list[Node] = items

    def __str__(self) -> str:
        return "[" + ", ".join(map(str, self.items)) + "]"


class Composite:
    def __init__(self):
        self.items: list[Node] = []

    def add(self, item: Node):
        self.items.append(item)

    def flatten(self) -> list[int]:
        raise NotImplementedError("flatten is not implemented yet")

    def __str__(self) -> str:
        return ", ".join(map(str, self.items))


if __name__ == "__main__":
    numbers = Composite()
    numbers.add(Value(0))
    numbers.add(List([Value(1), Value(2), Value(3)]))
    numbers.add(Value(4))
    numbers.add(List([Value(5), List([Value(6), List([Value(7)])])]))
    numbers.add(Value(8))
    numbers.add(List([Value(9)]))
    print(numbers)
    print(numbers.flatten())
