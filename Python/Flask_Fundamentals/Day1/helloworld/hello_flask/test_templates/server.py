from flask import Flask, render_template
app = Flask(__name__)
@app.route('/')
def indext():
    return render_template("index.html", phrase='hello', times=5)
app.run(debug=True)
