É	
yE:\_Storage\Giancarlo\_UniBrasil\_workspaceUnibrasil\NetcoreV3.SonarQ\NetcoreV3.SonarQ.Api\Controllers\LoginController.cs
	namespace 	
	NetcoreV3
 
. 
SonarQ 
. 
Api 
. 
Controllers *
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public		 

class		 
LoginController		  
:		! "
ControllerBase		# 1
{

 
private 
readonly 

IConexaoDB #

_conexaoDB$ .
;. /
[ 	
HttpPost	 
] 
public 
IActionResult 
Login "
(" #
)# $
{ 	
var 
result 
= 

_conexaoDB #
.# $
ValidaLogin$ /
(/ 0
$str0 7
,7 8
$str9 C
)C D
;D E
return 
base 
. 
Ok 
( 
result !
)! "
;" #
} 	
} 
} Â
eE:\_Storage\Giancarlo\_UniBrasil\_workspaceUnibrasil\NetcoreV3.SonarQ\NetcoreV3.SonarQ.Api\Program.cs
	namespace 	
	NetcoreV3
 
. 
SonarQ 
. 
Api 
{ 
[ #
ExcludeFromCodeCoverage 
] 
public 

class 
Program 
{		 
public

 
static

 
void

 
Main

 
(

  
string

  &
[

& '
]

' (
args

) -
)

- .
{ 	
CreateHostBuilder 
( 
args "
)" #
.# $
Build$ )
() *
)* +
.+ ,
Run, /
(/ 0
)0 1
;1 2
} 	
public 
static 
IHostBuilder "
CreateHostBuilder# 4
(4 5
string5 ;
[; <
]< =
args> B
)B C
=>D F
Host 
.  
CreateDefaultBuilder %
(% &
args& *
)* +
. $
ConfigureWebHostDefaults )
() *

webBuilder* 4
=>5 7
{ 

webBuilder 
. 

UseStartup )
<) *
Startup* 1
>1 2
(2 3
)3 4
;4 5
} 
) 
; 
} 
} ç
eE:\_Storage\Giancarlo\_UniBrasil\_workspaceUnibrasil\NetcoreV3.SonarQ\NetcoreV3.SonarQ.Api\Startup.cs
	namespace 	
	NetcoreV3
 
. 
SonarQ 
. 
Api 
{ 
[ #
ExcludeFromCodeCoverage 
] 
public 

class 
Startup 
{ 
public 
void 
ConfigureServices %
(% &
IServiceCollection& 8
services9 A
)A B
{ 	
services 
. 
AddControllers #
(# $
)$ %
;% &
services 
. 
	AddScoped 
< 

IConexaoDB )
,) *
ConexaoDBSqlServer+ =
>= >
(> ?
)? @
;@ A
services 
. 
	AddScoped 
< 
IAvaliacaoFisica /
,/ 0
AvaliacaoFisica1 @
>@ A
(A B
)B C
;C D
} 	
public 
void 
	Configure 
( 
IApplicationBuilder 1
app2 5
,5 6
IWebHostEnvironment7 J
envK N
)N O
{ 	
if 
( 
env 
. 
IsDevelopment !
(! "
)" #
)# $
{ 
app 
. %
UseDeveloperExceptionPage -
(- .
). /
;/ 0
}   
app"" 
."" 

UseRouting"" 
("" 
)"" 
;"" 
app$$ 
.$$ 
UseEndpoints$$ 
($$ 
	endpoints$$ &
=>$$' )
{%% 
	endpoints&& 
.&& 
MapGet&&  
(&&  !
$str&&! $
,&&$ %
async&&& +
context&&, 3
=>&&4 6
{'' 
await(( 
context(( !
.((! "
Response((" *
.((* +

WriteAsync((+ 5
(((5 6
$str((6 D
)((D E
;((E F
})) 
))) 
;)) 
	endpoints** 
.** 
MapControllers** (
(**( )
)**) *
;*** +
}++ 
)++ 
;++ 
},, 	
}-- 
}.. 