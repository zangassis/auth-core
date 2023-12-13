# AuthCore 🛡️

**This project contains a sample ASP.NET Core app. This app is an example of the article I produced for the Telerik Blog (telerik.com/blogs).**

AuthCore is an ASP.NET Core authentication app, leveraging .NET 8 minimal API and JWT (JSON Web Token) authentication. 🚀

## Features

- **Seamless Integration:** Easily integrate AuthCore into your ASP.NET Core applications.
  
- **Minimal API Design:** Keep your application lightweight and performant with .NET 8 minimal API.

- **Secure JWT Authentication:** Enhance security through the robust JWT authentication mechanism.

- **Easy Configuration:** Simple and flexible configuration options for seamless setup.

## Getting Started

### Prerequisites

- .NET 8 SDK installed ✔️
- Your favorite code editor (Visual Studio Code, Visual Studio, etc.) 🖥️

### Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/zangassis/auth-core.git
    cd AuthCore
    ```

2. Install dependencies:

    ```bash
    dotnet restore
    ```

### Run the Application

```bash
dotnet run
```

Visit `https://localhost:5001/swagger/index.html` in your browser to access the application. 🌐

## Usage

### Authentication

To obtain a JWT token, send a POST request to `/authenticate` with your credentials:

```json
{
    "email": "johnsmith@samplemail.com",
    "roles": [
        "admin"
    ]
}
```

## License

AuthCore is released under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contributing

We welcome contributions! 💡
