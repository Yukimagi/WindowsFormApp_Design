import tkinter as tk
#�ظm�e��
root = tk.Tk()
root.title('my window')
#�ظm�@�ӵe��
w = tk.Canvas(root, bd=10, bg='green', cursor='plus', height=400, width=400, )
w.pack()
#------------
def b1():
    w.create_oval(350, 350, 200, 200) # ���
    
def b2():
    w.delete("all")    

#�H���������
pixel = tk.PhotoImage(width='20', height='20')
button1=tk.Button(root, text="GO", fg="black", bg="gray", command=b1)
button1.config(image=pixel,compound="c")#�ݥ[compound="c"�~�|����r
button1.pack()
button1.place(x=250,y=4)

button2=tk.Button(root, text="GO", font=('Calibri',10,'bold'), fg="white", bg="red", command=b2)
button2.config(width='20', height='20')
button2.pack()
button2.place(x=10,y=4)
#��s�e��
root.mainloop()
