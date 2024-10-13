function searchProduct() {
    const query = document.getElementById('search').value;
    if (query) {
      alert('Searching for: ' + query);
    } else {
      alert('Please enter a search term.');
    }
  }
  