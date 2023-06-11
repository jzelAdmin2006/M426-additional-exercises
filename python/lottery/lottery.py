class LotteryDraw:
    def __init__(self, winning_numbers: list[int]):
        self.winning_numbers = winning_numbers

    def count_correct_numbers(self, bet: list[int]) -> int:
        # TODO: Count numbers in bet that are also in winning_numbers.
        pass

    def get_reward(
        self, bet: list[int], rewards: dict[int, float], bet_cost: float
    ) -> float:
        # TODO: Count correct numbers and look up the reward in rewards.
        # If a reward is found, return the amount (player wins) minus the bet_cost.
        # If no reward is found, return the bet_cost as a negative value (player looses).
        pass


class Lottery:
    def __init__(self, max_number: int, draw_size: int):
        self.min_number = 1
        self.max_number = max_number
        self.draw_size = draw_size

    def draw() -> LotteryDraw:
        # TODO: Draw draw_size random numbers from min_number to max_number.
        return LotteryDraw([])

    def create_random_bet(self) -> list[int]:
        # TODO: Return draw_size random numbers from min_number to max_number.
        return []


if __name__ == "__main__":
    player_budget = 100.0
    bet_cost = 2.0
    rewards = {
        3: 5.0,
        4: 75.0,
        5: 25_000.0,
        6: 1_000_000.0,
    }
    lottery = Lottery(45, 6)
    round = 0
    while player_budget > bet_cost:
        bet = lottery.create_random_bet()
        draw = lottery.draw()
        print(f"Player bet f{bet}, winning numbers: f{draw.winning_numbers}")
        correct = draw.count_correct_numbers(bet)
        win = draw.get_reward(bet, rewards, bet_cost)
        print(f"{correct} correct numbers, player wins {win}.")
        player_budget += win
        round += 1
    print(f"Player is broke after {round} rounds.")
