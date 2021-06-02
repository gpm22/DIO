# Cities Querying :city_sunrise:

API Rest created with Java 8, Spring, and PostgreSQL for querying world Countries and Brazilian Cities and States with comparative data and calculating the distance between two brazilian cities.

[data](https://github.com/chinnonsantos/sql-paises-estados-cidades/tree/master/PostgreSQL)

[Based on](https://github.com/andrelugomes/digital-innovation-one/tree/master/cities-api)

There are endpoints for retrieving:
* all Countries(/countries);
  * it is pageable;
* all States (/states);
  * it is pageable;
* all Cities (/cities);
  * it is pageable;
* a Country by Id (/countries/{id});
* a State by Id (/states/{id});
* a City by Id (/cities/{id});
* the distance between 2 cities using its ids, the method, and the unit (/distance/{method}?from={id}&to{id}&unit={unit})

## Distance methods

3 methods are available:

* **by-points**
  * First retrieve the points for each City and then use the formulas in `doCalculation`;
* **by-cube**
  * First retrieve the points for each City and then use the **earthdistance** PostgreSQL module for the calculations;
* **by-math**
  * Use directly the formulas in `doCalculation`;

The units availbles are:
* **meters**
  * unit=METERS
* **kilometers**
  * unit=KILOMETERS
* **miles**
  * unit=MILES

## DataBase

It is necessary to use the PostgreSQL modules cube and earthdistance, therefore the following commands must be executed in the database:

```SQL
CREATE EXTENSION cube;
CREATE EXTENSION earthdistance;
```

## Examples

* **Querying Countries**
  * getting all - GET to http://localhost:8080/countries?page=25&size=10&sort=name,desc

    <details>
        ```json
          {
          "content": [
              {
                  "id": 4,
                  "name": "Algeria",
                  "portugueseName": "Argélia",
                  "code": "DZ",
                  "bacen": 590
              },
              {
                  "id": 3,
                  "name": "Albania",
                  "portugueseName": "Albânia, Republica da",
                  "code": "AL",
                  "bacen": 175
              },
              {
                  "id": 253,
                  "name": "Åland Islands",
                  "portugueseName": "Aland, Ilhas",
                  "code": "AX",
                  "bacen": 153
              },
              {
                  "id": 2,
                  "name": "Afghanistan",
                  "portugueseName": "Afeganistão",
                  "code": "AF",
                  "bacen": 132
              }
          ],
          "pageable": {
              "sort": {
                  "sorted": true,
                  "unsorted": false,
                  "empty": false
              },
              "offset": 250,
              "pageNumber": 25,
              "pageSize": 10,
              "paged": true,
              "unpaged": false
          },
          "totalPages": 26,
          "totalElements": 254,
          "last": true,
          "size": 10,
          "number": 25,
          "sort": {
              "sorted": true,
              "unsorted": false,
              "empty": false
          },
          "numberOfElements": 4,
          "first": false,
          "empty": false
          }        
        ```

    </details>

  * getting one - GET to http://localhost:8080/countries/165
    <details>

        ```json

        {
        "id": 165,
        "name": "Palau",
        "portugueseName": "Palau",
        "code": "PW",
        "bacen": 5754
        }

        ```
    </details>

* **Querying States**
  * getting all - GET to http://localhost:8080/states?page=2&size=10&sort=name,desc

    <details>
      ```json
        {
          "content": [
              {
                  "id": 8,
                  "name": "Espírito Santo",
                  "uf": "ES",
                  "ibge": 32,
                  "country": {
                      "id": 1,
                      "name": "Brazil",
                      "portugueseName": "Brasil",
                      "code": "BR",
                      "bacen": 1058
                  },
                  "ddd": [
                      28,
                      27
                  ]
              },
              {
                  "id": 7,
                  "name": "Distrito Federal",
                  "uf": "DF",
                  "ibge": 53,
                  "country": {
                      "id": 1,
                      "name": "Brazil",
                      "portugueseName": "Brasil",
                      "code": "BR",
                      "bacen": 1058
                  },
                  "ddd": [
                      61
                  ]
              },
              {
                  "id": 6,
                  "name": "Ceará",
                  "uf": "CE",
                  "ibge": 23,
                  "country": {
                      "id": 1,
                      "name": "Brazil",
                      "portugueseName": "Brasil",
                      "code": "BR",
                      "bacen": 1058
                  },
                  "ddd": [
                      88,
                      85
                  ]
              },
              {
                  "id": 5,
                  "name": "Bahia",
                  "uf": "BA",
                  "ibge": 29,
                  "country": {
                      "id": 1,
                      "name": "Brazil",
                      "portugueseName": "Brasil",
                      "code": "BR",
                      "bacen": 1058
                  },
                  "ddd": [
                      77,
                      75,
                      73,
                      74,
                      71
                  ]
              },
              {
                  "id": 3,
                  "name": "Amazonas",
                  "uf": "AM",
                  "ibge": 13,
                  "country": {
                      "id": 1,
                      "name": "Brazil",
                      "portugueseName": "Brasil",
                      "code": "BR",
                      "bacen": 1058
                  },
                  "ddd": [
                      97,
                      92
                  ]
              },
              {
                  "id": 4,
                  "name": "Amapá",
                  "uf": "AP",
                  "ibge": 16,
                  "country": {
                      "id": 1,
                      "name": "Brazil",
                      "portugueseName": "Brasil",
                      "code": "BR",
                      "bacen": 1058
                  },
                  "ddd": [
                      96
                  ]
              },
              {
                  "id": 2,
                  "name": "Alagoas",
                  "uf": "AL",
                  "ibge": 27,
                  "country": {
                      "id": 1,
                      "name": "Brazil",
                      "portugueseName": "Brasil",
                      "code": "BR",
                      "bacen": 1058
                  },
                  "ddd": [
                      82
                  ]
              },
              {
                  "id": 1,
                  "name": "Acre",
                  "uf": "AC",
                  "ibge": 12,
                  "country": {
                      "id": 1,
                      "name": "Brazil",
                      "portugueseName": "Brasil",
                      "code": "BR",
                      "bacen": 1058
                  },
                  "ddd": [
                      68
                  ]
              }
          ],
          "pageable": {
              "sort": {
                  "sorted": true,
                  "unsorted": false,
                  "empty": false
              },
              "offset": 20,
              "pageNumber": 2,
              "pageSize": 10,
              "paged": true,
              "unpaged": false
          },
          "last": true,
          "totalPages": 3,
          "totalElements": 28,
          "size": 10,
          "number": 2,
          "sort": {
              "sorted": true,
              "unsorted": false,
              "empty": false
          },
          "first": false,
          "numberOfElements": 8,
          "empty": false
        }
      ```
    </details>

  * getting one - GET to http://localhost:8080/states/16

    <details>
      ```json
        {
            "id": 16,
            "name": "Pernambuco",
            "uf": "PE",
            "ibge": 26,
            "country": {
                "id": 1,
                "name": "Brazil",
                "portugueseName": "Brasil",
                "code": "BR",
                "bacen": 1058
            },
            "ddd": [
                81,
                87
            ]
        }
      ```
    </details>

* **Querying Cities**
  * getting all - GET to http://localhost:8080/cities?page=50&size=10&sort=name,desc
    <details>
        ```json
          {
          "content": [
              {
                  "id": 4284,
                  "name": "Sobradinho",
                  "uf": 23,
                  "ibge": 4320701,
                  "geolocation": "(-29.4193992614746,-53.032600402832)",
                  "location": {
                      "x": -29.4193992614746,
                      "y": -53.032600402832
                  }
              },
              {
                  "id": 5578,
                  "name": "Sobradinho",
                  "uf": 7,
                  "ibge": 5300108,
                  "geolocation": "(-15.7795000076294,-47.9296989440918)",
                  "location": {
                      "x": -15.7795000076294,
                      "y": -47.9296989440918
                  }
              },
              {
                  "id": 660,
                  "name": "Sobradinho",
                  "uf": 5,
                  "ibge": 2930774,
                  "geolocation": "(-9.45024013519287,-40.8144989013672)",
                  "location": {
                      "x": -9.45024013519287,
                      "y": -40.8144989013672
                  }
              },
              {
                  "id": 5554,
                  "name": "Sítio Novo do Tocantins",
                  "uf": 27,
                  "ibge": 1720804,
                  "geolocation": "(-5.60120010375977,-47.6380996704102)",
                  "location": {
                      "x": -5.60120010375977,
                      "y": -47.6380996704102
                  }
              },
              {
                  "id": 1327,
                  "name": "Sítio Novo",
                  "uf": 10,
                  "ibge": 2111805,
                  "geolocation": "(-5.87600994110107,-46.7033004760742)",
                  "location": {
                      "x": -5.87600994110107,
                      "y": -46.7033004760742
                  }
              },
              {
                  "id": 3832,
                  "name": "Sítio Novo",
                  "uf": 20,
                  "ibge": 2413706,
                  "geolocation": "(-6.11132001876831,-35.9090003967285)",
                  "location": {
                      "x": -6.11132001876831,
                      "y": -35.9090003967285
                  }
              },
              {
                  "id": 659,
                  "name": "Sítio do Quinto",
                  "uf": 5,
                  "ibge": 2930766,
                  "geolocation": "(-10.3544998168945,-38.2212982177734)",
                  "location": {
                      "x": -10.3544998168945,
                      "y": -38.2212982177734
                  }
              },
              {
                  "id": 658,
                  "name": "Sítio do Mato",
                  "uf": 5,
                  "ibge": 2930758,
                  "geolocation": "(-13.0801000595093,-43.4688987731934)",
                  "location": {
                      "x": -13.0801000595093,
                      "y": -43.4688987731934
                  }
              },
              {
                  "id": 1110,
                  "name": "Sítio d`Abadia",
                  "uf": 9,
                  "ibge": 5220702,
                  "geolocation": "(-14.7992000579834,-46.2505989074707)",
                  "location": {
                      "x": -14.7992000579834,
                      "y": -46.2505989074707
                  }
              },
              {
                  "id": 5421,
                  "name": "Siriri",
                  "uf": 25,
                  "ibge": 2807204,
                  "geolocation": "(-10.5965003967285,-37.1130981445313)",
                  "location": {
                      "x": -10.5965003967285,
                      "y": -37.1130981445313
                  }
              }
          ],
          "pageable": {
              "sort": {
                  "sorted": true,
                  "unsorted": false,
                  "empty": false
              },
              "offset": 500,
              "pageNumber": 50,
              "pageSize": 10,
              "paged": true,
              "unpaged": false
          },
          "totalPages": 560,
          "totalElements": 5594,
          "last": false,
          "size": 10,
          "number": 50,
          "sort": {
              "sorted": true,
              "unsorted": false,
              "empty": false
          },
          "numberOfElements": 10,
          "first": false,
          "empty": false
          }
        ```
    </details>
  * getting one - GET to http://localhost:8080/cities/165
    <details>

        ```json
          {
          "id": 165,
          "name": "Ouro Branco",
          "uf": 2,
          "ibge": 2706109,
          "geolocation": "(-9.15884017944336,-37.355598449707)",
          "location": {
              "x": -9.15884017944336,
              "y": -37.355598449707
          }
          }
        ```
    </details>

* **Calulating a distance**

  * **by points**
    * GET to http://localhost:8080/distance/by-points?from=165&to=5000&unit=KILOMETERS
    ```
      Distance from Ouro Branco to Jumirim in KILOMETERS: 1908.121547
    ```
  * **by math**
    * GET to http://localhost:8080/distance/by-math?from=165&to=5000&unit=KILOMETERS
    ```
      Distance from Ouro Branco to Jumirim in KILOMETERS: 1908.121547
    ```
  * **by cube**
    * GET to http://localhost:8080/distance/by-cube?from=165&to=5000&unit=KILOMETERS
    ```
      Distance from Ouro Branco to Jumirim in KILOMETERS: 1908.121556
    ```
