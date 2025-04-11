<template>
  <button class="btn btn-primary">Ahoj</button>
</template>
<script setup>
import axios from "axios";
axios
  .get("https://localhost:7165/weatherforecast")
  .then((response) => {
    console.log("Data z backendu:", response.data);
  })
  .catch((error) => {
    console.error("Chyba při načítání dat:", error);
  });
</script>
