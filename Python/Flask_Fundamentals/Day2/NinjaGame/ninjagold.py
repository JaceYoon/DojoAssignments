from flask import Flask, render_template, session, redirect, flash, request
import random

app = Flask(__name__)
app.secret_key = 'isKey'

@app.route('/')
def mainpage():
    return render_template('ninja.html')

app.run(debug=True)
