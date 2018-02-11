// GET
fetch('file.json')
  .then(response => response.json())
  .then(data => {
      console.log(data);
    }
  );
