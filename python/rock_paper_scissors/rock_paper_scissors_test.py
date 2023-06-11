import pytest

from .rock_paper_scissors import RockPaperScissors


@pytest.mark.parametrize(
    "player_one,player_two,expected_winner",
    [
        ("rock", "rock", 0),
        ("paper", "paper", 0),
        ("scissors", "scissors", 0),
        ("rock", "scissors", -1),
        ("scissors", "rock", 1),
        ("paper", "rock", -1),
        ("rock", "paper", 1),
        ("scissors", "paper", -1),
        ("paper", "scissors", 1),
    ],
)
def test_winner(player_one, player_two, expected_winner):
    # Arrange
    game = RockPaperScissors(player_one, player_two)

    # Act
    actual_winner = game.winner()

    # Assert
    assert actual_winner == expected_winner


@pytest.mark.parametrize(
    "player_one,player_two",
    [
        ("", ""),
        ("ROCK", "paper"),
        (" rock ", "paper"),
        ("sceezors", "rock"),
        ("scissors", "rocc"),
        ("paypa", "scissors"),
        ("paper", "5c1550r5"),
    ],
)
def test_validation(player_one, player_two):
    with pytest.raises(ValueError) as e:
        RockPaperScissors(player_one, player_two)
    assert "invalid" in str(e)
