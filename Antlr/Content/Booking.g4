grammar Booking;

@lexer::header {
    using System;
}

booking
    returns[Booking b]:
    'book' 'a' 'hotel' 'room' 'for' person 'guests' 'on' time {
      $b=new Booking();
      $b.Time=$time.t;
      $b.Person=$person.p;

    };
time
    returns[DateTime t]:
    d = datetime {
    Console.WriteLine($d.text);
    $t=DateTime.Parse($d.text);

};
person
    returns[Person p]:
    f = firstName l = lastName 'and' n = numberOfGuests {

       $p=new Person();
       $p.FirstName=$f.text;
       $p.LastName=$l.text;
       $p.NumberOfGuests=int.Parse($n.text);

   };

firstName: STRING;
lastName: STRING;
numberOfGuests: NUMBER;
datetime:
    NUMBER NUMBER SEPARATOR MONTH SEPARATOR YEAR NUMBER NUMBER COLON NUMBER NUMBER;
YEAR: NUMBER NUMBER NUMBER NUMBER;

NUMBER: [0-9];
MONTH:
    JAN
    | FEB
    | MAR
    | APR
    | MAY
    | JUN
    | JUL
    | AUG
    | SEP
    | OCT
    | NOV
    | DEC;

STRING: [a-zA-Z][a-zA-Z]+;
JAN: [Jj][Aa][Nn];
FEB: [Ff][Ee][Bb];
MAR: [Mm][Aa][Rr];
APR: [Aa][Pp][Rr];
MAY: [Mm][Aa][Yy];
JUN: [Jj][Uu][Nn];
JUL: [Jj][Uu][Ll];
AUG: [Aa][Uu][Gg];
SEP: [Ss][Ee][Pp];
OCT: [Oo][Cc][Tt];
NOV: [Nn][Oo][Vv];
DEC: [Dd][Ee][Cc];
SEPARATOR: '-';
COLON: ':';

WS: (' ' | '\r' | '\n' | '\t') -> channel(HIDDEN);