# Models

Creating Linux-esque soft link to ***directory only*** (admin cmd)
```
admin-cmd> mklink /J <target> <path\to\directory>

admin-cmd> mklink /J Models ..\Models
```

Second line can be used for each service directory *if* you're using the same project structure as described in Docker README