from django.shortcuts import render, get_object_or_404, redirect
from django.http import HttpResponse
from .forms import MemberForm
from .models import Members


def admin_console(request):
    members = Members.objects.all()
    return render(request, "m", {'members': members})