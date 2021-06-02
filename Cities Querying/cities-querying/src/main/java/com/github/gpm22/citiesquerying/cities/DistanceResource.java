package com.github.gpm22.citiesquerying.cities;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/distance")
public class DistanceResource {

    private final DistanceService service;
    Logger log = LoggerFactory.getLogger(DistanceResource.class);

    public DistanceResource(DistanceService service) {
        this.service = service;
    }

    @GetMapping("/by-points")
    public String byPoints(@RequestParam(name = "from") final Long city1,
                           @RequestParam(name = "to") final Long city2,
                           @RequestParam final EarthRadius unit) {
        log.info("byPoints");
        return String.format("Distance from %s to %s in %s: %f", service.cityName(city1), service.cityName(city2), unit, service.distanceUsingPoints(city1, city2, unit));
    }

    @GetMapping("/by-cube")
    public String byCube(@RequestParam(name = "from") final Long city1,
                         @RequestParam(name = "to") final Long city2,
                         @RequestParam String unit) {
        Double result = service.distanceByCube(city1, city2);
        System.out.print(result);

        if(unit.equals("MILES")){
            result = result*125/201168;
        } else if(unit.equals("KILOMETERS")){
            result = result/1000;
        } else if(unit.equals("METERS")){
        } else {
            return "no unit";
        }

        log.info("byCube");
        return String.format("Distance from %s to %s in %s: %f", service.cityName(city1), service.cityName(city2), unit, result);
    }

    @GetMapping("/by-math")
    public String byMath(@RequestParam(name = "from") final Long city1,
                         @RequestParam(name = "to") final Long city2,
                         @RequestParam final EarthRadius unit) {
        log.info("byMath");
        return String.format("Distance from %s to %s in %s: %f", service.cityName(city1), service.cityName(city2), unit ,service.distanceUsingMath(city1, city2, unit));
    }

}
