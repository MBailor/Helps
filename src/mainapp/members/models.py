from django.db import models


class Members(models.Model):
    First_Name = models.CharField(max_length=20, default="", blank=True, null=False)
    Last_Name = models.CharField(max_length=20, default="", blank=True, null=False)
    Starting_Balance = models.DecimalField(default=0.00, max_digits=100000000, decimal_places=2)

    objects = models.Manager()

    def __str__(self):
        return self.First_Name
