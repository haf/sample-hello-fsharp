FROM haaf/fsharp-http-app
MAINTAINER Henrik Feldt <henrik@haf.se>
COPY . /app

EXPOSE 8083

ENTRYPOINT ["/usr/bin/fsharpi", "Program.fsx"]