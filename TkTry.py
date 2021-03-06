from tkinter import *
import tkinter as tk


class ParentWin(Frame):
    def __init__(self, master, *args, **kwargs):
        Frame.__init__(self, master, *args, **kwargs)

        self.master = master       
        
        self.master.title("Check files")
        self.master.configure(bg="lightgray")

        self.master.protocol("WM_DELETE_WINDOW")
        arg = self.master

        self.b1 = Button(self.master, text="Browse", width=12).grid(row=2, column=0, padx=10, pady=5, sticky=S+W)
        self.e1 = Entry(self.master,text='', width="35").grid(row=2, column=1, columnspan=10, padx=10, pady=5, sticky=S+E)
        self.b2 = Button(self.master, text="Browse", width=12).grid(row=3, column=0, padx=10, pady=0, sticky=W)
        self.e2 = Entry(self.master, text='', width="35").grid(row=3, column=1, columnspan=10, padx=10, pady=0, sticky=E)
        self.b3 = Button(self.master, text="Check For Files...", height=2).grid(row=4, column=0, rowspan=3, padx=10, pady=10, sticky=S+W)
        self.b4 = Button(self.master, text="Close Program", height=2).grid(row=4, column=10, padx=10, pady=10, sticky=S+E)




if __name__ == "__main__":
    root = tk.Tk()
    App = ParentWin(root)
    root.mainloop()
    


