from flask import Flask, render_template, session, redirect

app = Flask(__name__)
app.secret_key = 'isKey'

def countIt():
    if "number" not in session:
        session["number"] = 0
    else:
        session["number"] += 1

@app.route('/', methods=['GET','POST'])
def cal():
    countIt()
    print session['number']
    return render_template('index.html')

@app.route('/double', methods=['GET','POST'])
def doublecount():
    countIt()
    print session['number']
    return redirect('/')
@app.route('/reset', methods=['GET','POST'])
def reset():
    session.clear()
    return redirect('/')
app.run(debug=True)
