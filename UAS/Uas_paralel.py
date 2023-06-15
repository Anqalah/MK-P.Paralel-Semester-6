### Multi threading ke-2 setelah convert file.py

import os
import tkinter as tk
from tkinter import filedialog
from tkinter import messagebox
import threading
import docx2pdf

def convert_to_pdf():
    # Mendapatkan daftar file Word
    file_paths = filedialog.askopenfilenames(filetypes=[("Word Documents", "*.docx")])

    # Membuat folder untuk menyimpan file yang terkonversi
    output_folder = "C:/Users/Lenovo/OneDrive/Dokumen"
    os.makedirs(output_folder, exist_ok=True)

    # Memulai thread untuk menjalankan konversi ke PDF
    thread = threading.Thread(target=convert_files, args=(file_paths, output_folder))
    thread.start()

def convert_files(file_paths, output_folder):
    try:
        threads = []

        for file_path in file_paths:
            # Membuat thread untuk setiap file Word
            thread = threading.Thread(target=convert_file, args=(file_path, output_folder))
            threads.append(thread)
            thread.start()

        # Menunggu semua thread selesai
        for thread in threads:
            thread.join()

        # Menampilkan pesan berhasil dalam kotak dialog
        messagebox.showinfo("Konversi Berhasil", "File berhasil dikonversi ke PDF.")
    except Exception as e:
        # Menampilkan pesan error dalam kotak dialog
        messagebox.showerror("Konversi Gagal", str(e))

def convert_file(file_path, output_folder):
    try:
        # Mengonversi file Word ke PDF
        pdf_path = os.path.join(output_folder, os.path.basename(file_path) + ".pdf")
        docx2pdf.convert(file_path, pdf_path)
    except Exception as e:
        # Menampilkan pesan error dalam kotak dialog
        messagebox.showerror("Konversi Gagal", str(e))

# Membuat GUI dengan menggunakan Tkinter
root = tk.Tk()
root.title("Konversi Word ke PDF")
root.geometry("400x200")

# Membuat label judul
title_label = tk.Label(root, text="Konversi File Word ke PDF", font=("Poppins", 16), bg="#FFFFFF")
title_label.pack(pady=20)

# Membuat tombol "Pilih File" untuk memilih file Word dan konversi ke PDF
select_button = tk.Button(root, text="Pilih File Word", font=("Arial", 12), command=convert_to_pdf, bg='#A2B38B')
select_button.pack()

# Menjalankan mainloop GUI
root.mainloop()
