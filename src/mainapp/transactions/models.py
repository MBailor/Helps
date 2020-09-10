from django.db import models




TYPE_CHOICES = [
    ("Deposit", "Deposit"),
    ("Withdrawl", "Withdrawl")
]

ACCT_CHOICES = [
    ("Checking", "Checking"),
    ("Savings", "Savings"),
]


class Transactions(models.Model):
    type_Transaction = models.CharField(max_length=10, choices=TYPE_CHOICES)
    Amount = models.DecimalField(default=0.00, max_digits=100000000, decimal_places=2)
    Description = models.TextField(max_length=150, default="", blank=True, null=False)
    Account = models.CharField(max_length=10, choices=ACCT_CHOICES)
    Current_Balance = models.DecimalField(default=0.00, max_digits=100000000, decimal_places=2)

    objects = models.Manager()

    def __str__(self):
        return self.Account
