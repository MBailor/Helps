from django.shortcuts import render, get_object_or_404, redirect
from django.http import HttpResponse
from .forms import ProductForm
from .models import Product


def admin_console(request):
    transactions = Transactions.objects.all()
    return render(request, transactions/BalanceSheet.html, {'transactions': transactions})