package com.github.gpm22.citiesquerying.repository;

import com.github.gpm22.citiesquerying.countries.Country;
import org.springframework.data.jpa.repository.JpaRepository;

public interface CountryRepository extends JpaRepository<Country, Long> {
}
