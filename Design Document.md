# Architecture
- Event log per human with interactions and results
- Use colliders + proximity lists for human interactions
- Offload interactions to seperate threads with thread safe properties on the humans
- Default simulation speed is minutes to seconds (x60 of real life)

# Virus
All the different ways the virus behaves, transmission likelyhoods, halftime, resistances, incubation time,...
### Transmission
- Physical interaction
- Close contact range aerosol (<= 0.5m)
- Short range aerosol (<= 1.5m)
- Medium range aersol (<= 5m)
- Large range aerosol (> 5m)
- Contact surfaces
- Water
- Food
- Body Liquids

### Halftime
- Surfaces
- Air
- Body Liquids
- Skin
- Water

### Resistances
- water
- soap
- disinfectant
- uv light
- heat
- cold

### Other
- Incubation time
- Minimum relevant concentration: The amount of virus particles that need to be active in a host to be relevant for reproduction (Verify with viroligist)
- Minimmum relevant reinfection concentration
- Lethality rate
- Asympthomatic rate
- Age groups

# Actions
The (inter)actions a human can take that might contract the virus

# Countermeasures
Any and all actions/restrictions that might reduces the virus from spreading

# Society
Additional parameters that influence the simulation

# Human
Individual parameters to track
- Likelyhood to perform actions
- Likelyhood to perform countermeasures
- Properties that influence infection rates
- Properties that influence lethality rates
