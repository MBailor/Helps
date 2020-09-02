

import tkinter
import tkinter as tk
from tkinter import *
from tkinter import ttk
from tkinter import filedialog
import shutil
import os
import time
import datetime as dt

class ParentWin(Frame):
    def __init__(self, master, folderDescription=""):
        Frame.__init__(self, master)
        
        self.master = master
        self.folderPath = StringVar()
        self.folderDest = StringVar()
        self.source = StringVar()
        self.destination = StringVar()
        self.master.title("Daily Shuffle")
        self.master.configure(bg="olivedrab")

        self.master.protocol("WM_DELETE_WINDOW")        

        self.lblOne = Label(self.master, text="Find Todays Files and Send Them Home!", font=("Helvetica", 14), bg="khaki").grid(row=1, column=2, padx=(10,15), pady=(20,10), columnspan=4, sticky=E)
        self.btnOne = ttk.Button(self.master, text="Find Files", width=12,command=self.setFolderPath).grid(row=2, column=0, padx=(10,0), pady=(10,10), sticky=W)
        self.entPath = Entry(self.master, textvariable=self.folderPath, width='62').grid(row=2, column=1, columnspan=5, padx=(10,5), pady=(20,10), sticky=S)
        self.btnTwo = ttk.Button(self.master, text="Find Dest", width=12,command=self.setFolderDest).grid(row=3, column=0, padx=(10,10), pady=(10,10), sticky=S)
        self.entPath1 = Entry(self.master, textvariable=self.folderDest, width='62').grid(row=3, column=1, columnspan=5, padx=(10,5), pady=(20,10), sticky=S)
        self.btnSnd = ttk.Button(self.master, text="Send Files", width=12, command=self.movee).grid(row=4, column=5, padx=(10,10), pady=(10,10), sticky=E)


    def setFolderPath(self):
        folder_selected = filedialog.askdirectory()
        self.folderPath.set(folder_selected)

    def folder_path(self):
        return self.folderPath.get()

    def setFolderDest(self):
        dest_selected = filedialog.askdirectory()
        self.folderDest.set(dest_selected)

    def folder_dest(self):
        return self.folderDest.get()

    def movee(self, days=1):
        source_file = self.folderPath.get()
        destination = self.folderDest.get()
        files = os.listdir(source_file)
        now = dt.datetime.now()
        file_time = now - dt.timedelta(hours=24)

    def mod_time(file):
        return (os.path.getmtime(file))
        for file in files:
            abspath = os.path.join(source_file, file)
            file_time = os.path.getmtime(abspath)
            print(file_time)
            if file.endswith('.txt') and mod_time > now:
                shutil.move(abspath, destination)

    
     

if __name__ == "__main__":
    root = tk.Tk()
    App = ParentWin(root)
    root.mainloop()

