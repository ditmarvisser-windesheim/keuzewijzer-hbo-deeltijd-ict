import { type View } from '../View';

export class LoginView implements View {
  public template = `<form>
    <h1 class="h3 mb-3 fw-normal">Login met uw account</h1>
    <p id="errorText" class="text-danger"></p>

    <div class="form-floating">
      <input type="email" class="form-control" id="emailInput" placeholder="name@example.com" required> 
      <label for="emailInput">Email address</label>
    </div>
    <div class="form-floating">
      <input type="password" class="form-control" id="passwordInput" placeholder="Password" required>
      <label for="passwordInput">Password</label>
    </div>

    <button class="w-100 btn btn-lg btn-primary" type="submit">Sign in</button>
  </form>`;

  public data = {};
  public authService: any;

  public setup (): void {
    const form = document.querySelector('form');
    const emailInput = document.getElementById('emailInput') as HTMLInputElement;
    const passwordInput = document.getElementById('passwordInput') as HTMLInputElement;

    if (form != null) {
      form.addEventListener('submit', (event) => {
        event.preventDefault();

        const email = emailInput.value;
        const password = passwordInput.value;

        this.login(email, password).catch((error) => {
          console.error('login failed: ', error);

          const errorText = document.getElementById('errorText');
          errorText!.innerText = 'Helaas is er iets fout gegaan. Probeer het later opnieuw.';
        });
      });
    }
  }

  private async login (email: string, password: string): Promise<void> {
    try {
      const loginResponse = await this.authService.login(email, password);

      if (loginResponse.status === 200) {
        // Login successful, redirect to home page
        window.location.href = '/';
      } else {
        // Login failed, show an error message
        const errorText = document.getElementById('errorText');
        errorText!.innerText = loginResponse.message;
      }
    } catch (error) {
      // An error occurred during the login process
      console.error('Login failed:', error);

      const errorText = document.getElementById('errorText');
      errorText!.innerText = 'Helaas is er iets fout gegaan. Probeer het later opnieuw.';
    }
  }
}
