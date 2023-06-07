class SidebarPartial {
    private userData: { username: string; email: string } | null;

    constructor(userData: { username: string; email: string } | null) {
        this.userData = userData;
    }

    public template = `
        <div class="sidebar">
          <div class="user-info">
            <h3>Welcome, ${this.userData?.username}!</h3>
            <p>Email: ${this.userData?.email}</p>
          </div>
          <ul>
            <li><a href="/dashboard">Dashboard</a></li>
            <li><a href="/profile">Profile</a></li>
            <li><a href="/settings">Settings</a></li>
          </ul>
        </div>

        <div class="d-flex flex-column align-items-center align-items-sm-start px-3 pt-2 text-white min-vh-100">
            <a href="/" class="d-flex align-items-center pb-3 mb-md-0 me-md-auto text-white text-decoration-none">
                <span class="fs-5 d-none d-sm-inline">HBO-ICT</span>
            </a>
            <ul class="nav nav-pills flex-column mb-sm-auto mb-0 align-items-center align-items-sm-start" id="menu">
                <li class="nav-item">
                    <a href="#" class="nav-link align-middle px-0">
                        <i class="fs-4 bi-house"></i> <span class="ms-1 d-none d-sm-inline">Home</span>
                    </a>
                </li>
                <li>
                    <a href="#" class="nav-link px-0 align-middle">
                        <i class="fs-4 bi-people"></i> <span class="ms-1 d-none d-sm-inline">Customers</span>
                    </a>
                </li>
                <li>
                    <a href="/semester" class="nav-link px-0 align-middle" data-link>
                        <i class="fs-4 bi-file-text"></i> <span class="ms-1 d-none d-sm-inline">Semester</span>
                    </a>
                </li>
                <li>
                    <a href="/cohort" class="nav-link px-0 align-middle" data-link>
                        <i class="fs-4 bi-file-text"></i> <span class="ms-1 d-none d-sm-inline">Cohort</span>
                    </a>
                </li>
                <li>
                    <a href="/user" class="nav-link px-0 align-middle" data-link>
                        <i class="fs-4 bi-file-text"></i> <span class="ms-1 d-none d-sm-inline">Gebruikers</span>
                    </a>
                </li>
            </ul>
            <hr>
            <div class="dropdown">
                <a href="#" class="d-flex align-items-center text-white text-decoration-none dropdown-toggle" id="dropdownUser1" data-bs-toggle="dropdown" aria-expanded="false">
                    <img src="https://github.com/mdo.png" alt="hugenerd" width="30" height="30" class="rounded-circle">
                    <span class="d-none d-sm-inline mx-1">loser</span>
                </a>
                <ul class="dropdown-menu dropdown-menu-dark text-small shadow" aria-labelledby="dropdownUser1">
                    <li><a class="dropdown-item" href="#">New project...</a></li>
                    <li><a class="dropdown-item" href="#">Settings</a></li>
                    <li><a class="dropdown-item" href="#">Profile</a></li>
                    <li>
                        <hr class=" dropdown-divider">
                    </li>
                    <li><a class="dropdown-item" href="#">Sign out</a></li>
                </ul>
            </div>
        </div>
      `;
}

export default SidebarPartial;