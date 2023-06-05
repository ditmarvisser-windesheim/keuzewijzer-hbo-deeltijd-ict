import { View } from '../View';
import AuthService from '../../services/AuthService';

export class LoginView implements View {
  public template = `<form>
    <h1 class="h3 mb-3 fw-normal">Please sign in</h1>

    <div class="form-floating">
      <input type="email" class="form-control" id="emailInput" placeholder="name@example.com">
      <label for="emailInput">Email address</label>
    </div>
    <div class="form-floating">
      <input type="password" class="form-control" id="passwordInput" placeholder="Password">
      <label for="passwordInput">Password</label>
    </div>

    <div class="checkbox mb-3">
      <label>
        <input type="checkbox" id="rememberMeInput"> Remember me
      </label>
    </div>
    <button class="w-100 btn btn-lg btn-primary" type="submit">Sign in</button>
    <p class="mt-5 mb-3 text-muted">© 2017–2021</p>
  </form>`;

  public data = {};
    authService: any;

  public setup(): void {
    const form = document.querySelector('form');
    const emailInput = document.getElementById('emailInput') as HTMLInputElement;
    const passwordInput = document.getElementById('passwordInput') as HTMLInputElement;
    const rememberMeInput = document.getElementById('rememberMeInput') as HTMLInputElement;

    if (form) {
      form.addEventListener('submit', (event) => {
        event.preventDefault();

        const email = emailInput.value;
        const password = passwordInput.value;
        const rememberMe = rememberMeInput.checked;

        this.login(email, password, rememberMe);
      });
    }
  }

  private async login(email: string, password: string, rememberMe: boolean): Promise<void> {
    try {
      const success = await this.authService.login(email, password);

      if (success) {
        // Login successful, redirect to the desired page
        window.location.href = '/dashboard'; // Replace with the desired page URL
      } else {
        // Login failed, show an error message
        const errorMessage = 'Invalid email or password';
        // Display the error message to the user
        // ...
      }
    } catch (error) {
      // An error occurred during the login process
      console.error('Login failed:', error);
      // Display an error message to the user
      // ...
    }
  }
}
