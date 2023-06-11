from .composite import Composite
from .composite import List
from .composite import Value


def test_flatten_empty_composite():
    # Arrange
    numbers = Composite()
    expected = []

    # Act
    actual = numbers.flatten()

    # Assert
    assert expected == actual


def test_flatten_values_only():
    # Arrange
    numbers = Composite()
    numbers.add(Value(0))
    numbers.add(Value(1))
    numbers.add(Value(2))
    expected = [0, 1, 2]

    # Act
    actual = numbers.flatten()

    # Assert
    assert expected == actual


def test_flatten_lists_of_values():
    # Arrange
    numbers = Composite()
    numbers.add(List([Value(1), Value(2), Value(3)]))
    numbers.add(List([Value(4), Value(5), Value(6)]))
    numbers.add(List([Value(7), Value(8), Value(9)]))
    expected = [1, 2, 3, 4, 5, 6, 7, 8, 9]

    # Act
    actual = numbers.flatten()

    # Assert
    assert expected == actual


def test_flatten_nested_lists_and_values():
    # Arrange
    numbers = Composite()
    numbers.add(Value(0))
    numbers.add(List([Value(1), Value(2), Value(3)]))
    numbers.add(Value(4))
    numbers.add(List([Value(5), List([Value(6), List([Value(7)])])]))
    numbers.add(Value(8))
    numbers.add(List([Value(9)]))
    expected = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]

    # Act
    actual = numbers.flatten()

    # Assert
    assert expected == actual
