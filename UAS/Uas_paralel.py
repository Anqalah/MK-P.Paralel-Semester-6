import os
import tkinter as tk
from tkinter import filedialog
from tkinter import messagebox
from tkinter.ttk import Progressbar
import threading
import docx2pdf
import time

# Fungsi untuk memulai proses konversi
def convert_to_pdf():
    # Membuka dialog file untuk memilih dokumen Word
    file_paths = filedialog.askopenfilenames(filetypes=[("Dokumen Word", "*.docx")])

    if len(file_paths) == 0:
        return

    # Membuka dialog folder untuk memilih folder tujuan penyimpanan file PDF
    output_folder = filedialog.askdirectory()
    if not output_folder:
        return

    # Memulai thread untuk melakukan konversi ke PDF
    thread = threading.Thread(target=convert_files, args=(file_paths, output_folder))
    thread.start()

# Fungsi untuk mengonversi beberapa file ke PDF
def convert_files(file_paths, output_folder):
    try:
        total_files = len(file_paths)
        progress_value = 0

        # Membuat jendela kemajuan
        progress_window = tk.Toplevel(root)
        progress_window.title("Proses Konversi")
        progress_window.geometry("300x100")

        # Membuat label untuk jendela kemajuan
        progress_label = tk.Label(progress_window, text="Konversi sedang berlangsung...", font=("Poppins", 12))
        progress_label.pack(pady=10)

        # Membuat progress bar
        progress_bar = Progressbar(progress_window, length=250, mode="determinate")
        progress_bar.pack(pady=10)

        for file_path in file_paths:
            # Memulai thread untuk mengonversi setiap file Word
            thread = threading.Thread(target=convert_file, args=(file_path, output_folder))
            thread.start()

            thread.join()  # Menunggu thread konversi selesai
            progress_value += 1
            progress_bar["value"] = (progress_value / total_files) * 100
            progress_window.update()

            # Menambahkan jeda selama 1 detik untuk efek thread
            time.sleep(2)

        # Menampilkan kotak dialog pesan berhasil
        messagebox.showinfo("Konversi Berhasil", "File berhasil dikonversi ke PDF.")

        # Menampilkan path folder tujuan dalam kotak dialog
        messagebox.showinfo("Folder Tujuan", f"File PDF disimpan di:\n{output_folder}")

        progress_window.destroy()
    except Exception as e:
        # Menampilkan kotak dialog pesan error jika terjadi exception
        messagebox.showerror("Konversi Gagal", str(e))
        progress_window.destroy()

# Fungsi untuk mengonversi satu file menjadi PDF
def convert_file(file_path, output_folder):
    try:
        # Mengonversi file Word menjadi PDF
        pdf_path = os.path.join(output_folder, os.path.basename(file_path) + ".pdf")
        docx2pdf.convert(file_path, pdf_path)
    except Exception as e:
        # Menampilkan kotak dialog pesan error jika terjadi exception
        messagebox.showerror("Konversi Gagal", str(e))

# Membuat GUI menggunakan Tkinter
root = tk.Tk()
root.title("Konversi Word ke PDF")
root.geometry("400x200")
root.configure(bg="#000000")

# Membuat label untuk judul
title_label = tk.Label(root, text="Konversi File Word ke PDF", font=("Poppins", 16), bg="black", fg="orange")
title_label.pack(pady=10)

# Membuat label untuk subjudul
subtitle_label = tk.Label(root, text="UAS P.Paralel Kelompok 7", font=("Poppins", 16), bg="black", fg="orange")
subtitle_label.pack(pady=10)

# Membuat tombol untuk memilih file Word dan mengonversinya ke PDF
select_button = tk.Button(root, text="Pilih File Word", font=("Arial", 12), command=convert_to_pdf, bg='#A2B38B')
select_button.pack(pady=20)

# Menjalankan event loop GUI
root.mainloop()
