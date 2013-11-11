function startFastcgi {
	/opt/mono/bin/fastcgi-mono-server4 /applications=/:`pwd` /socket=$1 &
}


startFastcgi 'unix:/tmp/nginx-0.sockets'
startFastcgi 'unix:/tmp/nginx-1.sockets'
startFastcgi 'unix:/tmp/nginx-2.sockets'
startFastcgi 'unix:/tmp/nginx-3.sockets'

chmod 777 /tmp/nginx-*