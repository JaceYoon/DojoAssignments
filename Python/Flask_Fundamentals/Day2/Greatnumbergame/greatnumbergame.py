from flask import Flask, render_template, session, redirect, flash, request
import random

app = Flask(__name__)
app.secret_key = 'isKey'

@app.route('/')
def main():
    if 'number' not in session:
        session['number'] = random.randrange(1,101)
    return render_template('index.html')
@app.route('/guess', methods=['GET','POST'])
def game():
    play = request.form['guess']
    if play.isdigit():
        num = int(play)
        asw = session['number']
        if num == asw:
            flash('You win!! Yeah!')

        elif num > asw and (num-asw) <= 10:
            flash('Almost..!! but little high!')

        elif num > asw and (num-asw) > 10:
            flash('Its too high!')

        elif num < asw and (asw-num) <= 10:
                flash('Almost..!! but little low!')

        else:
            flash('Its too Low')
    else:
        flash('Its not a number !!')
    return redirect('/')
@app.route('/reset', methods=['GET','POST'])
def reset():
    session.clear()
    return redirect('/')
app.run(debug=True)
