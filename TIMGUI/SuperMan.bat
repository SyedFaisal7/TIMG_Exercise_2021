call echo Syed Faisal you have got your super powers! Please dont share it
call timeout 10
call npm install @angular/cli --global
call ng new TIMGUI --skip-install --routing=true --style=css
call move TIMGUI\* . 
call move TIMGUI\e2e .
call move TIMGUI\src .
call mkdir wwwroot
call copy NUL wwwroot\text.txt
call echo Change the output path in 60 secs sir
call timeout 60
call npm install --save
call echo Do you want me to add paging sir?
call timeout 10
call Del package-lock.json
call npm install ngx-pagination
call echo Do you want me to add search-filter(Search) sir?
call timeout 10
call Del package-lock.json
call npm install ng2-search-filter
call echo Do you want me to add ngx-order-pipe(SORT) sir?
call timeout 10
call Del package-lock.json
call npm install ngx-order-pipe
call echo Do you want me to add Bootsrap and Jquery sir?
call timeout 10
call Del package-lock.json
call npm install bootstrap jquery
call echo Do you want me to add local web storage sir?
call timeout 10
call Del package-lock.json
call npm install angular-web-storage
call echo Do you want me to add all components sir?
call timeout 10
call ng g c pages/home -is --skipTests
call echo Do you want me to add all services sir?
call timeout 10
call ng g s service/api --skipTests
call echo Do you want me to add all Models sir?
call timeout 10
call ng g class models/Product --skipTests
call ng g class models/Order --skipTests
call ng g class models/OrderItem --skipTests
call ng g class models/Client --skipTests
call echo Do you want me to build sir?
call timeout 10
call npm install
call ng build
call ng serve
