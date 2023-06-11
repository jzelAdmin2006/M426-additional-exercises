class RockPaperScissors:
    def __init__(self, player_one: str, player_two: str):
        valid = ["rock", "paper", "scissors"]
        if player_one not in valid:
            raise ValueError(f"invalid move ${player_one}")
        if player_two not in valid:
            raise ValueError(f"invalid move ${player_two}")
        self.player_one = player_one
        self.player_two = player_two

    def winner(self) -> int:
        if self.player_one == self.player_two:
            return 0
        if self.player_one == "rock" and self.player_two == "scissors":
            return -1
        if self.player_one == "scissors" and self.player_two == "rock":
            return 1
        if self.player_one == "paper" and self.player_two == "rock":
            return -1
        if self.player_one == "rock" and self.player_two == "paper":
            return 1
        if self.player_one == "scissors" and self.player_two == "paper":
            return -1
        if self.player_one == "paper" and self.player_two == "scissors":
            return 1
        raise ValueError(f"{self.player_one}:{self.player_two} is undefined")
