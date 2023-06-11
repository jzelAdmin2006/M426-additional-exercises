import pytest

from .isbn13 import ISBN13


@pytest.mark.parametrize(
    "raw,expected",
    [
        ("9780134190440", True),
        ("9780262510875", True),
        ("9780262046305", True),
        ("9780465026562", True),
        ("9783518380635", True),
        ("9780131103627", True),
        ("9780262546379", True),
        ("0134190440", False),  # too short
        ("0000262510875", False),  # wrong prefix
        ("9780262X46305", False),  # X character in the middle
        ("9780460026562", False),  # invalid checksum (messed up number)
        ("9783518380634", False),  # invalid checksum (messed up checksum)
    ],
)
def test_correct_isbn13(raw, expected):
    # Arrange
    isbn13 = ISBN13(raw)

    # Act
    actual = isbn13.is_valid()

    # Assert
    assert actual is expected
