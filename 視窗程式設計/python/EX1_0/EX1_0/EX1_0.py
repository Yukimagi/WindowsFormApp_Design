import tkinter as tk 
#�ظm�e��
root = tk.Tk() 
root.title('window for rectangle') 
#�ظm�@�ӵe��
w = tk.Canvas(root, width=400, height=400) 
w.pack()#pack()���]
#�g�b�U��

w.create_rectangle(350,350,100,100) 
w.create_rectangle(350,350,200,150, outline='red') 
w.create_rectangle(350,350,200,200, outline='blue')
w.create_oval(350,350,200,200,outline='black')

##��s�e��
root.mainloop()
