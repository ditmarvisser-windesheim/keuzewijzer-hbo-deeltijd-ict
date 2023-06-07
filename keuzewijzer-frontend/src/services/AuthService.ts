import auth from '../api/auth';

class AuthService {
  constructor() {
  }

  private setAuthToken(token: string): void {
    localStorage.setItem('access_token', token);
  }

  private getAuthToken(): string | null {
    return localStorage.getItem('access_token');
  }

  public async login(username: string, password: string): Promise<boolean> {
    // Make an API request to authenticate the user
    // Example implementation:
    try {
      const response = await auth.login({ 'UserName': username, 'Password': password });

      if (response.status === 200) {
        const accessToken = response.data.token;

        // Store the access token securely
        this.setAuthToken(accessToken);

        return true;
      } else {
        console.error('Login failed:', response.data);
        return false;
      }
    } catch (error) {
      console.error('Login failed:', error);
      return false;
    }
  }

  public logout(): void {
    localStorage.removeItem('access_token');
  }

  public isAuthenticated(): boolean {
    // Check if the user is authenticated based on the access token stored in local storage
    const accessToken = this.getAuthToken();
    return !!accessToken;
  }
}

export default AuthService;
