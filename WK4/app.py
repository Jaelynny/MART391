from flask import Flask, redirect, url_for, session, request
from authlib.integrations.flask_client import OAuth

app = Flask(__name__)
app.secret_key = 'your_secret_key'
oauth = OAuth(app)

auth0 = oauth.register(
    'auth0',
    client_id='2NF044H4UlIX7MDt6aD21GZ0R20bojx8',
    client_secret='Jzywm4WVI-72RSEoJTYI4UMYgqhKLpkIb5E8e-RFwGy7_ztgJiAEZ2sDHaO3Plw1',
    api_base_url='https://dev-x3oipshuw2dy8t1a.us.auth0.com',
    access_token_url='https://dev-x3oipshuw2dy8t1a.us.auth0.com.auth0.com/oauth/token',
    authorize_url='https://dev-x3oipshuw2dy8t1a.us.auth0.com.auth0.com/authorize',
    client_kwargs={
        'scope': 'openid profile email',
    },
)

@app.route('/')
def index():
    return 'Welcome to the Auth0 OAuth example!'

@app.route('/login')
def login():
    return auth0.authorize_redirect(redirect_uri=url_for('authorized', _external=True))

@app.route('/logout')
def logout():
    session.clear()
    return redirect(url_for('index'))

@app.route('/login/authorized')
def authorized():
    token = auth0.authorize_access_token()
    user_info = auth0.parse_id_token(token)
    session['user'] = user_info
    return 'Logged in as: ' + user_info['email']

if __name__ == '__main__':
    app.run()
