import tkinter as tk
from PIL import Image, ImageTk 

#�ظm�e��
root = tk.Tk()
root.title('image window')
img = Image.open('pic.png')
img1 = ImageTk.PhotoImage(img)
#�ظm�@�ӵe��
w = tk.Canvas(root, width=img.size[0], height=img.size[1])
w.pack()
#�g�b�U��
w.create_image(0,0, anchor=tk.NW, image=img1)

#��s�e��
root.mainloop()
