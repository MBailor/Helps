import os
import datetime
import shutil
import tkinter as tk
import datetime as dt
from tkinter import *

class ParentWin(Frame):
    def __init__(self,master):
        Frame.__init__(self,master)
        self.master = master
        self.master.configure(bg="olivedrab")
        self.grid_rowconfigure(0, weight=1)
        self.grid_columnconfigure(0, weight=1)

        self.master.protocol("WM_DELETE_WINDOW")
        arg = self.master

        
        self.master.title("Daily Shuffle")
        self.lblOne = Label(text="Look For  And Move Them All To Another Folder", font=("Helvetica", 14), bg="khaki")
        self.lblOne.grid(row=0, column=0, padx=5, pady=5, columnspan=4)
        self.folderPath = StringVar()
        self.Destination = StringVar()
        self.btnFind = Button(self.master, text="Choose Folder For Program To Check", width=20, height=1, bg="khaki", command=self.setFolderPath)
        self.btnFind.grid(row=1, column=0, padx=(5,5), pady=(5,5))
        self.entPath = Entry(self, textvariable=self.folderPath)
        self.entPath.grid(row=1, column=1, padx=(10,10), pady=(10,10), columnspan=3)
        self.btnFind1 = Button(self.master, text="Choose Destination Folder", width=20, height=1, bg="khaki", command=self.setFolderPath)
        self.btnFind1.grid(row=2, column=0, padx=(5,5), pady=(5,5,))
        self.entPath1 = Entry(self, textvariable=self.folderPath)
        self.entPath1.grid(row=2, column=1, padx=(10,10), pady=(10,10), columnspan=3) 
        
        self.btnOrg = Button(self.master, text="Organize Files Now!", width=20, height=1, command=self.setMoveTime)

    def setFolderPath(self):
        folder_selected = Tkinter.filedialog.Directory
        self.folderPath.set(folder_selected)
    @property
    def folder_path(self):
        return self.folderPath.get()

    def setMoveTime(self):
        source = '/Users/Student/Desktop/InBoxF/'
        destination = '/Users/Student/Desktop/DailyDest/'
        files = os.listdir(source)

        for i in files:     
            shutil.move(source+i, destination)


if __name__ == "__main__":
    root= tk.Tk()
    App= ParentWin(root)
    root.mainloop()















