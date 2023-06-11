import { login, logout } from '../api/auth';

interface LoginResult {
  status: number;
  message: string;
}

class AuthService {
  private setAuthToken (token: string): void {
    localStorage.setItem('access_token', token);
  }

  private getAuthToken (): string | null {
    return localStorage.getItem('access_token');
  }

  public getUserData(): { userId: string, username: string, email: string } | null	 {
    return localStorage.getItem('user_data') ? JSON.parse(localStorage.getItem('user_data')!) : null;
  }

  private setUserData (userData: { userId: string, username: string, email: string }): void {
    localStorage.setItem('user_data', JSON.stringify(userData));
  }

  public async login (username: string, password: string): Promise<LoginResult> {
    // Make an API request to authenticate the user
    // Example implementation:
 
      return await login({ UserName: username, Password: password })
        .then((response) => {
          var message: string = '';

          if (response.status === 401) {
            message = 'Invalid username or password';
          } else if (response.status === 200) {
            const accessToken = response.accessToken;

            this.setAuthToken(accessToken);
            this.setUserData({ userId: response.userId, username: username, email: username + '@test.nl' });
            message = 'Login successful';
          } else {
            message = 'An unknown error occurred';
          }

          console.log('Login response', response);

          return {
            status: response.status,
            message: message
          };
        }).catch((error) => {
          console.error('Error login', error);
          return {
            status: 500,
            message: error
          };
        });

  }

  public async logout (): Promise<void> {
    return await logout({})
    .then((response) => {
      console.log(response);
      localStorage.removeItem('access_token');

    }).catch((error) => {
      console.error('Error login', error);
    });
  }

  public isAuthenticated (): boolean {
    // Check if the user is authenticated based on the access token stored in local storage
    const accessToken = this.getAuthToken();
    console.log('accessToken', accessToken);
    console.log(typeof accessToken);
    console.log('accessToken != null', accessToken != null);
    console.log('accessToken != undefined', accessToken != undefined);

    return accessToken != null && accessToken != undefined && accessToken !== 'undefined';
  }
}

export default AuthService;
